using Microsoft.AspNetCore.Http.Timeouts;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Modul_3.Customert.Web.Customers;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static CustomerData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<CustomerData>();
builder.Services.AddTransient<IEmailMessageFactory, EmailMessageFactory>();

//Mailsettings konfigurálása:
var mailSetting = builder.Configuration.GetSection(nameof(MailSettings)).Get<MailSettings>(); 
builder.Services.AddSingleton(mailSetting);

builder.Services.AddTransient<IEmailSenderService, ConsoleOnlyEmailSenderService>();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddTransient<IEmailSenderService, ConsoleOnlyEmailSenderService>();
}
else 
{
    builder.Services.AddTransient<IEmailSenderService, MailKitEmailSenderServices>();   

}
//builder.Services.AddTransient<CustomerEmailService>(); //ezt nem lhet változtatni, ezért ez lesz belple:
builder.Services.AddTransient<ICustomerEmailService, CustomerEmailService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.MapCustomerEndpoints();
RouteHandlerBuilder routeHandlerBuilder = app.MapGet("/brewcoffee", (HttpResponse response) =>
{
    response.StatusCode = 418;
    response.ContentType = "text/plain";
    return response.WriteAsync("I'm a teapot - I cannot brew coffee");
})
    .WithName("BrewCoffee");

app.Run();



public readonly record struct UpdateCustomerRequest : IValidatableObject
{
    [Required]
    [MinLength(10)]

    public string CompanyName { get; init; }
    public List<Project> Projects { get; init; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (CompanyName == "NimblePros")
        {
            yield return new ValidationResult("Company Name Cannot be NimblePros.",
                new[] { nameof(CompanyName) });
        }
    }
}

public record struct PutRequest : IValidatableObject
{
    [FromRoute(Name ="id")]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public Customer Customer { get; set; }
    public CustomerData Data { get; set; }
    //[EmailAddress]
    //public string EmailAddress { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (String.IsNullOrEmpty(Customer.CompanyName))
        {
            yield return new ValidationResult("COmpany Name is required.",
                new[] { nameof(Customer.CompanyName) });
        }
    }
}


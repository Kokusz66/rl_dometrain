using Microsoft.AspNetCore.Http.Timeouts;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;
using Modul_3.Customert.Web.Customers;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static CustomerData;

var builder = WebApplication.CreateBuilder(args);

//Add EF Core Services to the container:
builder.Services.AddDbContext<AppDbContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    //videóhoz képest javítva a jelenlegi verzióra:
    config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "NimbusPros Customer FLY",
        Description = "Api for managing customers",
        Version = "1.0"
    });
});

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
app.Run();
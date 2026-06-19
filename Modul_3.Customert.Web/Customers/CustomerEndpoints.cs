using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Modul_3.Customert.Web.Customers
{
    public static class CustomerEndpoints
    {
        public static void MapCustomerEndpoints(this WebApplication app)
        {
            //routGroup:
            var customeGroup = app.MapGroup("/customers")
                .WithOpenApi()
                .WithTags("Customers");

            var customerGroupWithValidation = customeGroup.MapGroup("/")
                .WithParameterValidation();

            customeGroup.MapGet("/", async (CustomerData data) =>
            {
                var customers = await data.ListAsync();
                return TypedResults.Ok(customers);
            })
                .WithDescription("List all customers.")
                .WithSummary("List Customers")
                
            .WithName("ListCustomers");

            customeGroup.MapGet("/{id:guid}", async (Guid id, CustomerData data) =>
                await data.GetByIdAsync(id) is Customer customer
                    ? TypedResults.Ok<Customer>(customer)
                    : Results.NotFound()
            )
            .WithName("GetCustomerById");

            customerGroupWithValidation.MapPost("/",
                async (CreateCustomerRequest request,
                CustomerData data,
                ICustomerEmailService customerEmailService) =>
                {
                    var newCustomer = new Customer(Guid.NewGuid(), request.CompanyName, new());
                    await data.AddAsync(newCustomer);

                    
                    await customerEmailService.SendWellcomeEmail(newCustomer);

                    return Results.Created($"/customers/{newCustomer.Id}", newCustomer);
                })
                .Produces<Customer>(StatusCodes.Status201Created)
                .ProducesValidationProblem(StatusCodes.Status400BadRequest)
            .AddEndpointFilter<ValidateCustomer>()
            .WithName("AddCustomer");

            customerGroupWithValidation.MapPut("/{id:guid}",
                async (Guid id, UpdateCustomerRequest request, CustomerData data) =>
                {
                    var existingCustomer = await data.GetByIdAsync(id);

                    if (existingCustomer is null)
                    {
                        return Results.NotFound();
                    }

                    var updatedCustomer = existingCustomer with
                    {
                        CompanyName = request.CompanyName,
                        Project = request.Projects
                    };

                    await data.UpdateAsync(id, updatedCustomer);

                    return Results.Ok(updatedCustomer);
                })
                .ProducesProblem(StatusCodes.Status404NotFound)
            .WithName("UpdateCustomer");


            customeGroup.MapDelete("/{id:guid}",
                //desc. hozzáadása:
                [EndpointDescription("(description)Delete a customer.")]
                //vagy xml csak ahhoz nem szabad lambdát használni
                async (Guid id, CustomerData data) =>
            {
                if (await data.GetByIdAsync(id) is null)
                {
                    return Results.NotFound();
                }

                await data.DeleteAsync(id);
                return Results.NoContent();
            })
            .WithName("DeleteCustomer");


            RouteHandlerBuilder routeHandlerBuilder = app.MapGet("/brewcoffee", (HttpResponse response) =>
            {
                response.StatusCode = 418;
                response.ContentType = "text/plain";
                return response.WriteAsync("I'm a teapot - I cannot brew coffee");
            })
                .ProducesProblem(StatusCodes.Status404NotFound)
                .WithName("BrewCoffee");

        }

    }
}

public record Customer(Guid Id, string CompanyName, List<Project> Project);
public record Project(Guid Id, string ProjectName, Guid CustomerId);

public readonly record struct CreateCustomerRequest : IValidatableObject
{
    [Required]
    [MinLength(10)]

    public string CompanyName { get; init; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (CompanyName == "NimblePros")
        {
            yield return new ValidationResult("Company Name Cannot be NimblePros.",
                new[] { nameof(CompanyName) });
        }
    }
}

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
    [FromRoute(Name = "id")]
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

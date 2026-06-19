public class ValidationHelpers
{
    internal static async ValueTask<object?> ValidateAddCustomer(EndpointFilterInvocationContext context,
    EndpointFilterDelegate next)
    {
        //check if valid
        var customer = context.GetArgument<Customer>(0);
        if (customer is not null && String.IsNullOrEmpty(customer.CompanyName))
        {
            return Results.ValidationProblem(new Dictionary<string, string[]>
            {
                { "comapnyName", new[] { "Company name is required" } }
            });
        }

        return await next(context);
    }


}


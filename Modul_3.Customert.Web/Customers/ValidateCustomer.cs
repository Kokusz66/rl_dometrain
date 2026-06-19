public class ValidateCustomer : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context,
        EndpointFilterDelegate next)
    {
        var customer = context.Arguments
            .OfType<Customer>()
            .FirstOrDefault();

        if (customer is not null &&
            string.IsNullOrWhiteSpace(customer.CompanyName))
        {
            return Results.ValidationProblem(
                new Dictionary<string, string[]>
                {
                    { "companyName", new[] { "Company name is required" } }
                });
        }

        return await next(context);
    }
}


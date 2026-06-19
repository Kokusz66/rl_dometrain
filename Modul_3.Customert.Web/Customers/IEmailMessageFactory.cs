namespace Modul_3.Customert.Web.Customers
{
    public interface IEmailMessageFactory
    {
        string GenerateEmailBody(Customer newCustomer);
    }
}
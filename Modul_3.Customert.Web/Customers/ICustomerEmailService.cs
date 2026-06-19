namespace Modul_3.Customert.Web.Customers
{
    public interface ICustomerEmailService
    {
        Task SendWellcomeEmail(Customer newCustomer);
    }
}






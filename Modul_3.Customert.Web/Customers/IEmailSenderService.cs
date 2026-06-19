namespace Modul_3.Customert.Web.Customers
{
    public interface IEmailSenderService
    {
        Task SndEmailAsync(string from, string to, string subject, string body);
    }
}
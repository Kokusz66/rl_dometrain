using MailKit.Net.Smtp;
using MimeKit;

namespace Modul_3.Customert.Web.Customers
{
    //Mailkit javítva a friss verziónak megfelelően

    //ne használjuk az Iconfiguration-t bemeneti paraméterként, nem ajánlja Steve
    /*
    public class MailKitEmailSenderServices(IConfiguration config) : IEmailSenderService
    private readonly IConfiguration _config = config;
    függvényen belül:
    int port = int.Parse(_config["MailSettings:Port"]);
    */

    public record MailSettings(int Port, string Server);

    public class MailKitEmailSenderServices(MailSettings mailSettings) : IEmailSenderService
    {
        private readonly MailSettings mailSettings = mailSettings;

        public async Task SendEmailAsync(string from, string to, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient())
            {
                //await client.ConnectAsync("localhost", 25, false); //régi
                await client.ConnectAsync(mailSettings.Server, mailSettings.Port, false);

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(from, from));
                message.To.Add(new MailboxAddress(to, to));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                await client.SendAsync(message);

                Console.WriteLine("Email sent!");

                await client.DisconnectAsync(true);
            }
        }

        public Task SndEmailAsync(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
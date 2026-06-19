using MailKit.Net.Smtp;
using MimeKit;

namespace Modul_3.Customert.Web.Customers
{
    //Mailkit javítva a friss verziónak megfelelően
    public class MailKitEmailSenderServices : IEmailSenderService
    {
        public async Task SendEmailAsync(string from, string to, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient())
            {
                await client.ConnectAsync("localhost", 25, false);

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
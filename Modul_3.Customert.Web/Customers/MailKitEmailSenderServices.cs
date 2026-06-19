using MimeKit;
using System.Net.Mail;

namespace Modul_3.Customert.Web.Customers
{
    public class MailKitEmailSenderServices : IEmailSenderService
    {
        public async Task SendEmailAsync(string from, string to, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient())
            {
                //client.Connect("localhot", 25, false); //ez a régi verzióban kellett
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(from, from));
                message.To.Add(new MailboxAddress(to, to));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                //await client.Send(message); //a konvertálást a régi és az új verzió között még meg kell néznem!
                Console.WriteLine("Email sent!");

                //client.Disconnect(true); //ez is a régi az újban már nem kell
            }
        }

        //ez nem is kellene csak hisztizik az interface-re
        public Task SndEmailAsync(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
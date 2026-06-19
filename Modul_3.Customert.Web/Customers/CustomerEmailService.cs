using MimeKit;
using Modul_3.Customert.Web.Customers;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Security;
using System.Net.Mail;
using System.Runtime.InteropServices.Marshalling;

namespace Modul_3.Customert.Web.Customers
{


    public class CustomerEmailService : ICustomerEmailService
    {

        private readonly IEmailMessageFactory emailMessageFactory;
        private readonly IEmailSenderService mailKitEmailSenderServices;

        public CustomerEmailService(
            IEmailMessageFactory emailMessageFactory, IEmailSenderService emailSenderServices)
        {
            this.emailMessageFactory = emailMessageFactory;
            this.mailKitEmailSenderServices = emailSenderServices;
        }

        internal async Task SendWelcomeEmail(Customer newCustomer)
        {
            string from = "donotreply@nimblepros.com";
            string to = "regisztralo@gmail.com"; //newCustomer.EmailAddress;
            string subject = "Welcome!";

            string template = "Welcome to Laci's wonderland, {{CompanyNam}}!";

            var emailMessageFactory = new EmailMessageFactory();
            string body = emailMessageFactory.GenerateEmailBody(newCustomer);

            Console.WriteLine($"Email küldése {to}-tól, {from}-nak.");

           
        }

        private static async Task SendEmailAsync(string from, string to, string subject, MailMessage message)
        {
            using (var client = new SmtpClient())
            {
                //client.Connect("smtp.friends.com", 587, false);

                
                //client.Authenticate("joey", "password");

                client.Send(message);
                //client.Disconnect(true);
            }
        }

        public Task SendWellcomeEmail(Customer newCustomer)
        {
            Console.WriteLine("Elküldve...");
            return Task.CompletedTask;
        }
    }

    public class ConsoleOnlyEmailSenderService : IEmailSenderService
    {
        public Task SendEmailAsync(string from, string to, string subject, string body)
        {
            Console.WriteLine($"Sending email from {from} to {to} with subject {subject} and body {body}");
            return Task.CompletedTask;
        }

        public Task SndEmailAsync(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }

    public class MailKitEmailSnderService : IEmailSenderService
    {
        public async Task SndEmailAsync(string from, string to, string subject, string body)
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

    }
}

    public class EmailMessageFactory : IEmailMessageFactory
    {
        public string GenerateEmailBody(Customer newCustomer)
        {
            string template = "Welcome to Laci's wonderland {CompanyName}}!";
            string body = template.Replace("{{CompanyName}}", newCustomer.CompanyName);
            return body;
        }
    }






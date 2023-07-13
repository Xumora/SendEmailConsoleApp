using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using SendEmailClassLibrary.Models;

namespace SendEmailClassLibrary.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(EmailDto request, EmailConfig config)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(config.email));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Plain) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(config.email, config.password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}

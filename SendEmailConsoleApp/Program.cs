using SendEmailClassLibrary;
using SendEmailClassLibrary.Models;
using SendEmailClassLibrary.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        EmailDto mail = new EmailDto();

        Console.WriteLine("Mail To");
        mail.To = Console.ReadLine();

        Console.WriteLine("Subject");
        mail.Subject = Console.ReadLine();

        Console.WriteLine("Your Message");
        mail.Body = Console.ReadLine();

        IEmailService emailService = new EmailService();
        SendEmailClass sendEmailClass = new SendEmailClass(emailService);

        sendEmailClass.SendEmail(mail);
    }
}
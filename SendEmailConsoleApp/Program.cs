using Microsoft.Extensions.DependencyInjection;
using SendEmailClassLibrary;
using SendEmailClassLibrary.Models;
using SendEmailClassLibrary.Services;
using ServiceCollectionExtension;

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

        IEmailService emailService = ServiceCollectionBuilder.BuildServiceProvider().GetService<IEmailService>();
        SendEmailClass sendEmailClass = new SendEmailClass(emailService);
        sendEmailClass.SendEmail(mail);
    }
}
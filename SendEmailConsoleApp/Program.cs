using SendEmailClassLibrary;
using SendEmailClassLibrary.Models;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();

        EmailDto mail = new EmailDto();
        EmailConfig mailConfig = new EmailConfig();

        mailConfig.email = config.GetSection("EmailConfig").GetSection("Email").Value;
        mailConfig.password = config.GetSection("EmailConfig").GetSection("Password").Value;

        Console.WriteLine("Mail To");
        mail.To = Console.ReadLine();

        Console.WriteLine("Subject");
        mail.Subject = Console.ReadLine();

        Console.WriteLine("Your Message");
        mail.Body = Console.ReadLine();

        SendEmailClass sendEmailClass = new SendEmailClass();
        sendEmailClass.SendEmail(mail, mailConfig);
    }
}
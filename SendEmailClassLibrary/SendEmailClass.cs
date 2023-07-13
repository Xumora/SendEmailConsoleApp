using Microsoft.Extensions.DependencyInjection;
using SendEmailClassLibrary.Models;
using SendEmailClassLibrary.Services;

namespace SendEmailClassLibrary
{
    public class SendEmailClass
    {   
        public void SendEmail(EmailDto request, EmailConfig config)
        {
            IEmailService emailService = ServiceCollectionExtension.GetServiceProvider().GetService<IEmailService>();
            emailService.SendEmail(request, config);
        }
    }
}

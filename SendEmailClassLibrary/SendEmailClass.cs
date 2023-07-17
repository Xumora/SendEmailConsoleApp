using SendEmailClassLibrary.Models;
using SendEmailClassLibrary.Services;

namespace SendEmailClassLibrary
{
    public class SendEmailClass
    {   
        private readonly IEmailService _emailService;
        public SendEmailClass(IEmailService emailService) { 
            _emailService = emailService;
        }
        public void SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);
        }
    }
}

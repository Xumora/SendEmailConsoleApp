using SendEmailClassLibrary.Models;

namespace SendEmailClassLibrary.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}

using Microsoft.Extensions.DependencyInjection;
using SendEmailClassLibrary.Services;

namespace SendEmailClassLibrary
{
    public class ServiceCollectionExtension
    {
        public static IServiceProvider GetServiceProvider()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<IEmailService, EmailService>();

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}

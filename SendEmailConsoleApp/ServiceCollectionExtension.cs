using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendEmailClassLibrary.Services;

namespace ServiceCollectionExtension
{
    public static class ServiceCollectionBuilder
    {
        private static IConfiguration GetConfig()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration config = builder.Build().GetSection("EmailServiceConfig");
            return config;
        }
        public static IServiceProvider BuildServiceProvider()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IEmailService, EmailService>(services => new EmailService(GetConfig()));
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
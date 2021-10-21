using System;
using DotnetCoreSmtp.BLL.EmailSender.Abstract;
using DotnetCoreSmtp.BLL.EmailSender.Concrete;
using DotnetCoreSmtp.Service.Manager.Abstract;
using DotnetCoreSmtp.Service.Manager.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCoreSmtp.Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollections)
        {
            // Dependency injection of manager classes
            serviceCollections.AddScoped<ISmtpManager, SmtpManager>();
            serviceCollections.AddScoped<IEmailSender, EmailSender>();
            return serviceCollections;
        }
    }
}

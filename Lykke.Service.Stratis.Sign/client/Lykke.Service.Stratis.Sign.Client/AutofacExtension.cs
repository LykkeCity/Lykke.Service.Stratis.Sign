using System;
using Autofac;
using Common.Log;

namespace Lykke.Service.Stratis.Sign.Client
{
    public static class AutofacExtension
    {
        public static void RegisterStratis.SignClient(this ContainerBuilder builder, string serviceUrl, ILog log)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            if (serviceUrl == null) throw new ArgumentNullException(nameof(serviceUrl));
            if (log == null) throw new ArgumentNullException(nameof(log));
            if (string.IsNullOrWhiteSpace(serviceUrl))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(serviceUrl));

            builder.RegisterType<Stratis.SignClient>()
                .WithParameter("serviceUrl", serviceUrl)
                .As<IStratis.SignClient>()
                .SingleInstance();
        }

        public static void RegisterStratis.SignClient(this ContainerBuilder builder, Stratis.SignServiceClientSettings settings, ILog log)
        {
            builder.RegisterStratis.SignClient(settings?.ServiceUrl, log);
        }
    }
}

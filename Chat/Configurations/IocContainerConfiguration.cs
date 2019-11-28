using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Configurations
{
    /// <summary>
    /// IOC contaner startup configuration
    /// </summary>
    public static class IocContainerConfiguration
    {
        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        public static void ConfigureService(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureDomainServices(services);
        }

        private static void ConfigureDomainServices(IServiceCollection services)
        {
            services.AddSingleton<IChatUserCache, ChatUserCache>();
        }
    }
}

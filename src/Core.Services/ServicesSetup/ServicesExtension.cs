using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Services.ServicesSetup
{
    public static class ServicesExtension
    {
        public static void AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            new ServiceHost().Configure(services, configuration);
        }
    }
}

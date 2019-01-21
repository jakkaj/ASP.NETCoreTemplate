using System;
using System.Collections.Generic;
using System.Text;
using Core.Models.Settings;
using Core.Services.Contract;
using Core.Services.Template;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ITemplateService = Core.Contracts.Template.ITemplateService;

namespace Core.Services.ServicesSetup
{
    public class ServiceHost : IServiceHost
    {
        public IServiceCollection Services { get; private set; }
        public IServiceProvider ServiceProvier { get; private set; }


        public ServiceHost Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ITemplateService, TemplateService>();
           
            services.Configure<CoreSettings>(configuration.GetSection(nameof(CoreSettings)));

            return this;
        }

        public IServiceProvider Build()
        {
            ServiceProvier = Services.BuildServiceProvider();
            return ServiceProvier;
        }
    }
}

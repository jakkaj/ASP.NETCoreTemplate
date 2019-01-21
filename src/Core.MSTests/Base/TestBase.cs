using System;
using System.Collections.Generic;
using System.Text;
using Core.Services.ServicesSetup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.MSTests.Base
{
    public class TestBase
    {
        private IServiceProvider ServiceProvider { get; set; }
        private IServiceCollection ServiceCollection { get; set; }

        public TestBase()
        {
            var builder = new ConfigurationBuilder();
            // tell the builder to look for the appsettings.json file
            builder
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            builder.AddUserSecrets<TestBase>();
            var Configuration = builder.Build();


            ServiceCollection = new ServiceCollection();

            ServiceCollection.AddCoreServices(Configuration);


            ServiceProvider = ServiceCollection.BuildServiceProvider();
        }

        public T Resolve<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}

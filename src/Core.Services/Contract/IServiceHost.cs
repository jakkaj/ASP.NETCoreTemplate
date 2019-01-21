using System;
using Core.Services.ServicesSetup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Services.Contract
{
    public interface IServiceHost
    {
        IServiceCollection Services { get; }
        IServiceProvider ServiceProvier { get; }
        ServiceHost Configure(IServiceCollection services, IConfiguration configuration);
        IServiceProvider Build();
    }
}
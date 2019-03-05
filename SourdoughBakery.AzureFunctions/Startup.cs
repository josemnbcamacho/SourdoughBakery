using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SourdoughBakery.AzureFunctions;
using SourdoughBakery.Business.Interfaces;
using SourdoughBakery.Business.Mock;

[assembly: WebJobsStartup(typeof(Startup))]
namespace SourdoughBakery.AzureFunctions
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProductService, MockProductService>();
            services.AddTransient<IMenuService, MockMenuService>();
        }
    }
}

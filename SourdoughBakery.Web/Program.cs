using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SourdoughBakery.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args)
        {
            // string port = Environment.GetEnvironmentVariable ("PORT") ?? "8080";
            // string url = string.Concat ("http://0.0.0.0:", port);

            return WebHost.CreateDefaultBuilder (args)
                .UseStartup<Startup>();
        }
    }
}

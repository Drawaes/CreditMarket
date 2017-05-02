using CreditMarket.CreditService.Core;
using Microsoft.AspNetCore.Hosting;
using System;

namespace CreditMarket.CreditService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}

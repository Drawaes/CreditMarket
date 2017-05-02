﻿using CreditMarket.CreditService.Core;
using DasMulli.Win32.ServiceUtils;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditMarket.CreditService.Service
{
    public class WindowsService : IWin32Service
    {
        private IWebHost _host;

        public string ServiceName => "CreditMarket.CreditService";
                
        public void Start(string[] startupArguments, ServiceStoppedCallback serviceStoppedCallback)
        {
            _host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5001")
                .UseStartup<Startup>()
                .Build();

            _host.Start();
        }

        public void Stop()
        {
            _host.Dispose();
        }
    }
}

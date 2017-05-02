using DasMulli.Win32.ServiceUtils;
using System;

namespace CreditMarket.CreditService.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new WindowsService();
            var serviceHost = new Win32ServiceHost(service);
            serviceHost.Run();
        }
    }
}

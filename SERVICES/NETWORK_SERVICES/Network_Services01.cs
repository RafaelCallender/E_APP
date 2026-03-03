
using System.Net;
using System.Net.NetworkInformation;

namespace E_APP.SERVICES.NETWORK_SERVICES
{
    internal class Network_Services01
    {
        private string[] data = new string[100];
        public string scan_netwrok()
        {
            var GetAllNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var entry in GetAllNetworkInterfaces)
            {
                data[0] += $"{entry.Name.ToString()}\n";

            }
            return data[0];
        }
        public string network_monitor()
        {

            while (true)
            {
                var GetIsNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();
                if (GetIsNetworkAvailable)
                {
                    data[0] = "Network is available";
                }
                else
                {
                    data[0] = "Network is not available";
                }
                Thread.Sleep(5000);
                return data[0];
            }
        }
        public string network_monitor01()
        {

      
            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {   
              
                    data[0] += $"Name: {adapter.Name}" +
                               $"Id: {adapter.Id}\n" +
                               $"NetworkInterfaceType: {adapter.NetworkInterfaceType}\n" +
                               $"Speed: {adapter.Speed}\n" +
                               $"IPProperties: {adapter.GetIPProperties}\n" +
                               $"Description: {adapter.Description}\n" +
                               $"DnsAddresses: {adapter.GetIPProperties().DnsAddresses}\n";
                
            }
            return data[0];
        }
    }
}


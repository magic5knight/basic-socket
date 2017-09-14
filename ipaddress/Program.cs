using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ipaddress
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] a = new byte[4];
            //for (int i = 0; i < a.Length; i++)
            //    a[i] = 10;
            //IPAddress ip = IPAddress.Parse("192.168.1.10");
            //Console.WriteLine("IP: {0}", ip);
            //Console.WriteLine("Any: {0}", IPAddress.Any);
            //Console.WriteLine("Broadcast: {0}", IPAddress.Broadcast);
            //Console.WriteLine("Loopback: {0}", IPAddress.Loopback);

            //IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("123.123.12.13"), 12345);
            //Console.WriteLine("Ipendpoint: {0}", ipe);
            //Console.WriteLine("Ip: {0}", ipe.Address);
            //Console.WriteLine("Ip: {0}", ipe.AddressFamily);

            IPHostEntry iphe = Dns.GetHostByAddress("74.125.200.101");
            foreach(IPAddress i in iphe.AddressList)
                Console.WriteLine("Ip: {0}", i);
            foreach(string s in iphe.Aliases)
                Console.WriteLine("alias: {0}", s);
            Console.WriteLine("host name: {0}", iphe.HostName);
            Console.ReadKey();

        }
    }
}

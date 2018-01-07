using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Configuration;
using MathTypes;
using System;

namespace MathServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1

            ServiceHost host = new ServiceHost(typeof(MathService),
                new Uri(ConfigurationManager.AppSettings["baseAddress"]));

            host.AddServiceEndpoint(typeof(IMath), new BasicHttpBinding(), "math");
            host.Open();

            Console.WriteLine("MathService is listening on the following...");
            Console.WriteLine();

            foreach (ServiceEndpoint e in host.Description.Endpoints)
            {
                Console.Write("ServiceEndpoint address: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(e.Address.ToString());
                Console.ResetColor();
                Console.Write("   ");
                Console.Write("ServiceEndpoint name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(e.Binding.Name);
                Console.ResetColor();
            }

            Console.WriteLine();
            Console.WriteLine("\n Press [Enter] to terminate.");
            Console.ReadLine();

            #endregion

        }
    }
}

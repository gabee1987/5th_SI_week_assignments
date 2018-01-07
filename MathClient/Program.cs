using MathTypes;
using System;
using System.ServiceModel;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1

            //IMath mathChannel =
            //new ChannelFactory<IMath>(new BasicHttpBinding(),
            //new EndpointAddress("http://localhost:8080/math")).CreateChannel();

            //MathTypes.MathRequest req = new MathTypes.MathRequest(25, 45);
            //MathTypes.MathResponse response = null;

            //MathTypes.IMath channel = new ChannelFactory<MathTypes.IMath>(
            //        new BasicHttpBinding(),
            //        new EndpointAddress("http://localhost:8080/math")).CreateChannel();
            //response = channel.Add(req);

            //Console.WriteLine();
            //Console.Write("Call via BasicProfileBinding: ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(response.result);
            //Console.ResetColor();

            //Console.ReadKey(true);

            #endregion

            #region Exercise 2

            MathTypes.MathRequest req = new MathTypes.MathRequest(23, 44);
            MathTypes.MathRequestMessage mreq = new MathTypes.MathRequestMessage();
            mreq.request = req;
            mreq.CustomHeader = 8;
            MathTypes.MathResponseMessage response = null;
            MathTypes.IMath channel = new ChannelFactory<MathTypes.IMath>(
                                                                        new BasicHttpBinding(),
                                                                        new EndpointAddress("http://localhost:8080/math")).CreateChannel();
            response = channel.Add(mreq);
            Console.WriteLine("Call via BasicProfileBinding: {0}",
            response.response.result);
            Console.ReadKey(true);

            #endregion
            //Console.Write("Call via BasicHttpBinding: ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(req);
            //Console.ResetColor();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Press [Enter] to exit.");
            //Console.ReadLine();
        }
    }
}

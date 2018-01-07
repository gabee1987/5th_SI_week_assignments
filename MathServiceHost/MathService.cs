using MathTypes;
using System.ServiceModel;
using System;

namespace MathServiceHost
{
    class MathService : IMath
    {
        #region IMath Members(Exercise 1)

        //public MathTypes.MathResponse Add(MathTypes.MathRequest req)
        //{
        //    return new MathTypes.MathResponse(req.x + req.y);
        //}

        //public MathTypes.MathResponse Subtract(MathTypes.MathRequest req)
        //{
        //    return new MathTypes.MathResponse(req.x - req.y);
        //}

        //public MathTypes.MathResponse Multiply(MathTypes.MathRequest req)
        //{
        //    return new MathTypes.MathResponse(req.x * req.y);
        //}

        //public MathTypes.MathResponse Divide(MathTypes.MathRequest req)
        //{
        //    return new MathTypes.MathResponse(req.x / req.y);
        //}

        #endregion


        #region IMath Member(Exercise 2)

        public MathTypes.MathResponseMessage Add(MathTypes.MathRequestMessage req)
        {
            Console.Write("Custom header value ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(req.CustomHeader);
            Console.ResetColor();

            MathTypes.MathResponseMessage resp = new MathTypes.MathResponseMessage();
            resp.response = new MathTypes.MathResponse(req.request.x + req.request.y);
            return resp;
        }

        public MathTypes.MathResponseMessage Subtract(MathTypes.MathRequestMessage req)
        {
            Console.Write("Custom header value ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(req.CustomHeader);
            Console.ResetColor();

            MathTypes.MathResponseMessage resp = new MathTypes.MathResponseMessage();
            resp.response = new MathTypes.MathResponse(req.request.x - req.request.y);
            return resp;
        }

        public MathTypes.MathResponseMessage Multiply(MathTypes.MathRequestMessage req)
        {
            Console.Write("Custom header value ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(req.CustomHeader);
            Console.ResetColor();

            MathTypes.MathResponseMessage resp = new MathTypes.MathResponseMessage();
            resp.response = new MathTypes.MathResponse(req.request.x * req.request.y);
            return resp;
        }

        public MathTypes.MathResponseMessage Divide(MathTypes.MathRequestMessage req)
        {
            Console.Write("Custom header value ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(req.CustomHeader);
            Console.ResetColor();

            MathTypes.MathResponseMessage resp = new MathTypes.MathResponseMessage();
            resp.response = new MathTypes.MathResponse(req.request.x / req.request.y);
            return resp;
        }

        #endregion
    }
}

using System.ServiceModel;
using System.Runtime.Serialization;

namespace MathTypes
{
    [ServiceContract(Namespace = "http://localhost:8080/math")]
    public interface IMath
    {
        //[OperationContract]
        //MathResponse Add(MathRequest req);
        //[OperationContract]
        //MathResponse Subtract(MathRequest req);
        //[OperationContract]
        //MathResponse Multiply(MathRequest req);
        //[OperationContract]
        //MathResponse Divide(MathRequest req);

        [OperationContract]
        MathTypes.MathResponseMessage Add(MathTypes.MathRequestMessage req);
        [OperationContract]
        MathTypes.MathResponseMessage Subtract(MathTypes.MathRequestMessage req);
        [OperationContract]
        MathTypes.MathResponseMessage Multiply(MathTypes.MathRequestMessage req);
        [OperationContract]
        MathTypes.MathResponseMessage Divide(MathTypes.MathRequestMessage req);
    }

        [MessageContract]
        public class MathRequestMessage
        {
            [MessageHeader]
            public int CustomHeader;
            [MessageBodyMember]
            public MathRequest request;
        }

        [MessageContract]
        public class MathResponseMessage
        {
            [MessageBodyMember]
            public MathResponse response;
        }

}

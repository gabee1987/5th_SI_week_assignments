using System.Runtime.Serialization;

namespace MathTypes
{
    [DataContract(Namespace = "http://localhost:8080/math")]
    public class MathResponse
    {
        public MathResponse(double result)
        {
            this.result = result;
        }

        [DataMember]
        public double result;

}
}

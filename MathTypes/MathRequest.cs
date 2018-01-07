using System.Runtime.Serialization;


namespace MathTypes
{
    [DataContract(Namespace = "http://localhost:8080/math")]
    public class MathRequest
    {
        public MathRequest(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        [DataMember]
        public double x;
        [DataMember]
        public double y;
}
}


namespace GeometryApp.Exceptions
{
    public class CircleInvalidRoundPrecisionException : InvalidRoundPrecisionException
    {
        public CircleInvalidRoundPrecisionException(string name, int precision) : base(name, precision)
        {
        }
    }
}

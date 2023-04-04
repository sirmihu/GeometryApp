
namespace GeometryApp.Exceptions
{
    public class SquareInvalidRoundPrecisionException : InvalidRoundPrecisionException
    {
        public SquareInvalidRoundPrecisionException(string name, int precision) : base(name, precision)
        {
        }
    }
}


using GeometryApp.Models;

namespace GeometryApp.Exceptions
{
    public abstract class InvalidRoundPrecisionException : Exception
    {
        public InvalidRoundPrecisionException(string name, int precision) : base
            ($"[{name}] invalid precision defined: {precision}")
        {
        }
    }
}

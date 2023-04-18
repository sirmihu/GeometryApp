using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryApp.Exceptions
{
    public class RectangleInvalidRoundPrecisionException : InvalidRoundPrecisionException
    {
        public RectangleInvalidRoundPrecisionException(string name, int precision) : base(name, precision)
        {
        }
    }
}

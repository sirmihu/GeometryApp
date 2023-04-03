
namespace GeometryApp.Utiles
{
    public class MathConstans
    {
        private double _piValue;
        public double Pi
        {
            get
            {
                _piValue = Math.PI;
                return _piValue;
            }
            set
            {
                _piValue = value;
            }
        }
    }
}

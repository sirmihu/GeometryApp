using GeometryApp.Exceptions;
using GeometryApp.Utiles;
using System.Security.Cryptography.X509Certificates;

namespace GeometryApp.Models
{
    public class Circle : Figure, IUtils
    {
        public double Radius { get; set; }
        public int Precision { get; set; }

        public Circle(double radius, int precision, string name) : base(name)
        {
            Radius = radius;
            Precision = precision;
            Name = name;
            CalculateArea();
        }

        public override string GetName()
        {
            return nameof(Circle);
        }
        public override void CalculateArea()
        {
            Area = Convert.ToDouble(MathConstans.Pi) * Math.Pow(Radius, 2);
            Round(Area, Precision);
            Console.WriteLine($"[{GetName()}] my area is equal to: {Area}.");

        }
        public void Round(double value, int digits)
        {
            if (digits > 3)
            {
                throw new CircleInvalidRoundPrecisionException(Name, digits);
            }
            Area = Math.Round(value, digits);
            Console.WriteLine($"Area rounded to decimal places: {digits}, in {Name}");
        }
    }
}

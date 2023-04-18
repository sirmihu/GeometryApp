using GeometryApp.Exceptions;
using GeometryApp.Utiles;

namespace GeometryApp.Models
{
    public class Rectangle : Figure, IUtils
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public int Precision { get; set; }

        public Rectangle(string name) : base(name) { }
        public Rectangle(double sideA, double sideB, int precision, string name) : this(name)
        {
            SideA = sideA;
            SideB = sideB;
            Precision = precision;
            Name = name;
            CalculateArea();
        }

        public override string GetName()
        {
            return nameof(Rectangle);
        }

        public override void CalculateArea()
        {
            Area = SideA * SideB;
            Round(Area, Precision);
            Console.WriteLine($"[{GetName()}] my area is equal to: {Area}");
        }

        public void Round(double value, int digits)
        {
            if (digits > 4)
            {
                throw new RectangleInvalidRoundPrecisionException(Name, digits);
            }
            Area = Math.Round(value, digits);
            Console.WriteLine($"Area rounded to decimal places: {digits}, in {Name}");
        }
    }
}

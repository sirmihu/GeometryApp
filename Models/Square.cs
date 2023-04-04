using GeometryApp.Exceptions;
using GeometryApp.Utiles;

namespace GeometryApp.Models
{
    public class Square : Figure, IUtiles
    {
        public double SideLength { get; set; }
        public int Precision { get; set; }

        public Square(string name) : base(name) { }
        public Square(double sideLength, int precision, string name) : this(name)
        {
            SideLength = sideLength;
            Precision = precision;
            Name = name;
            CalculateArea();
        }

        public override string GetName()
        {
            return nameof(Square);
        }

        public override void CalculateArea()
        {
            Area = Math.Pow(SideLength, 2);
            Round(Area, Precision);
            Console.WriteLine($"[{GetName()}] my area is equal to: {Area}");
        }

        public void Round(double value, int digits)
        {
            if (digits > 4)
            {
                throw new SquareInvalidRoundPrecisionException(Name, digits);
            }
            Area = Math.Round(value, digits);
            Console.WriteLine($"Area rounded to decimal places: {digits}, in {Name}");
        }
    }
}

using GeometryApp.Utiles;

namespace GeometryApp.Models
{
    public class Square : Figure, IUtiles
    {
        private double sideLength;
        private int precision;

        public Square(string name) : base(name) { }
        public Square(double sideLength, int precision, string name) : this(name)
        {
            this.sideLength = sideLength;
            this.precision = precision;
        }

        public override string GetName()
        {
            return "Square";
        }

        public override string CalculateArea()
        {
            double area = sideLength * sideLength;
            return $"[{Name}] my area is equal to: {area}";
        }

        public double Round(double value, int digits)
        {
            double roundedValue = Math.Round(value, digits);
            Area = roundedValue;
            Console.WriteLine($"Field rounded to decimal places: {digits}, in {Name}");
            return roundedValue;
        }
    }
}

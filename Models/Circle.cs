using GeometryApp.Utiles;

namespace GeometryApp.Models
{
    public class Circle : Figure, IUtiles
    {
        private readonly MathConstans _mathConstans;
        public double Radius { get; set; }
        public int Precision { get; set; }

        public Circle(double radius, int precision, string name) : base(name)
        {
            Radius = radius;
            Precision = precision;
        }

        public override string GetName()
        {
            return "Circle";
        }
        public override string CalculateArea()
        {
            double area = _mathConstans.Pi * Radius * Radius;
            return $"[{Name}] my area is equal to: {area}";

        }
        public double Round(double value, int digits)
        {
            throw new NotImplementedException();
        }
    }
}


namespace GeometryApp.Models
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Figure(string name)
        {
            Console.WriteLine($"Hi from {name}.");
        }

        public abstract string GetName();
        public abstract void CalculateArea();
    }
}

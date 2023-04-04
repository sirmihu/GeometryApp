using GeometryApp.Exceptions;
using GeometryApp.Models;
using GeometryApp.Scenarios;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var figures = new Application().Seed();

        foreach (var figure in figures)
        {
            try
            {
                if (figure.FigureType == FigureType.Square)
                    new Square(figure.Value, figure.RoundPrecision, figure.Name);
                else if (figure.FigureType == FigureType.Circle)
                    new Circle(figure.Value, figure.RoundPrecision, figure.Name);
            }
            catch (InvalidRoundPrecisionException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            

        }

    }
}
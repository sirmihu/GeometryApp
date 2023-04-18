using GeometryApp.Exceptions;
using GeometryApp.Models;
using System.Xml.Linq;

class Application
{
    static void Main(string[] args)
    {
        var figures = new List<FigureValue>()
            {
                new FigureValue { FigureType = FigureType.Square, Name = "Kwadracik nr 1",
                    Value = 5, RoundPrecision = 2 },
                new FigureValue { FigureType = FigureType.Square, Name = "Kwadracik nr 2",
                    Value = 5, RoundPrecision = 5 },
                new FigureValue { FigureType = FigureType.Circle, Name = "Kółeczko nr 1",
                    Value = 3.3, RoundPrecision = 7 },
                new FigureValue { FigureType = FigureType.Circle, Name = "Kółeczko nr 2",
                    Value = 3, RoundPrecision = 2 },
                new FigureValue { FigureType = FigureType.Rectangle, Name = "Prostokącik nr 1",
                    ValueA = 5, ValueB = 8, RoundPrecision = 2}
            };
        
        foreach (var figure in figures)
        {
            try
            {
                if (figure.FigureType == FigureType.Square)
                    new Square(figure.Value, figure.RoundPrecision, figure.Name);
                else if (figure.FigureType == FigureType.Circle)
                    new Circle(figure.Value, figure.RoundPrecision, figure.Name);
                else if (figure.FigureType == FigureType.Rectangle)
                    new Rectangle(figure.ValueA, figure.ValueB, figure.RoundPrecision, figure.Name);
            }
            catch (InvalidRoundPrecisionException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            

        }

    }
}
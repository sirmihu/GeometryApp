using GeometryApp.Models;

namespace GeometryApp.Scenarios
{
    public class Application
    {
        public List<FigureValue> Seed()
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
                    Value = 3, RoundPrecision = 2 }
            };

            return figures;

        }
    }
}
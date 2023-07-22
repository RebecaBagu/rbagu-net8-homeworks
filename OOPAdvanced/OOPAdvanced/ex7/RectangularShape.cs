using System;
namespace OOPAdvanced.ex7
{
    public class RectangularShape : IDimensions
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public RectangularShape()
        {
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public string GetArea(AreaMeasurementUnit unit)
        {
            return $"Area: {GetArea()} {unit}";
        }
    }
}

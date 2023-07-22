using System;
namespace OOPAdvanced.ex3
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle(string color, double width, double height)
        {
            Color = color;
            Width = width;
            Height = height;
        }

        public override void CalculateArea()
        {
            Area = Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public string GetPerimeter(MeasurementUnit unit)
        {
            return $"Perimeter: {GetPerimeter()} {unit}";
        }
    }
}

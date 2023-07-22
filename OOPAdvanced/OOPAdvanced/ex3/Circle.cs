using System;
namespace OOPAdvanced.ex3
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string color,double radius)
        {
            Color = color;
            Radius = radius;
        }

        public override void CalculateArea()
        {
            Area = Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public string GetPerimeter(MeasurementUnit unit)
        {
            return $"Circumference: {GetPerimeter()} {unit}";
        }
    }
}

using System;
using OOPAdvanced.ex3;

namespace OOPAdvanced.ex6
{
    public class Circle : IShape, IColor
    {
        private double radius;

        public string Color { get; set; }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.Color = color;
        }

        public Circle(double radius) : this(radius, "Black")
        {
        }


        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public string CalculateArea(MeasurementUnit measurementUnit)
        {
            return $"Area: {CalculateArea()} square {measurementUnit}";
        }
    }
}

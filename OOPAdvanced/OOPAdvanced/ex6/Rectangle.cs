using System;
using OOPAdvanced.ex3;

namespace OOPAdvanced.ex6
{
    public class Rectangle : IShape, IColor
    {
        private double width;
        private double height;

        public string Color { get; set; }

        public Rectangle(double width, double height, string color)
        {
            this.width = width;
            this.height = height;
            this.Color = color;
        }

        public Rectangle(double width, double height) : this(width, height, "Black")
        {
        }


        public double CalculateArea()
        {
            return width * height;
        }

        public string CalculateArea(MeasurementUnit measurementUnit)
        {
            return $"Area: {CalculateArea()} square {measurementUnit}";
        }
    }
}

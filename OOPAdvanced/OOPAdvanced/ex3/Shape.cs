using System;
namespace OOPAdvanced.ex3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public double Area { get; set; }

        public abstract void CalculateArea();
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}

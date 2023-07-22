using System;
using OOPAdvanced.ex3;

namespace OOPAdvanced.ex6
{
    public interface IShape
    {
        double CalculateArea();
        string CalculateArea(MeasurementUnit unit);
    }
}

using System;
namespace OOPAdvanced.ex7
{
    public interface IDimensions
    {
        double Width { get; set; }
        double Height { get; set; }

        double GetArea();
        string GetArea(AreaMeasurementUnit unit);
    }
}

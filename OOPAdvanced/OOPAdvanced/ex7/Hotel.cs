using System;
using System.Collections.Generic;

namespace OOPAdvanced.ex7
{
    public class Hotel : RectangularShape
    {
        public List<Floor> Floors { get; private set; }

        public Hotel(int width, int height)
        {
            Width = width;
            Height = height;
            Floors = new List<Floor>();
        }

        public void AddFloor(Floor floor)
        {
            Floors.Add(floor);
        }
    }
}

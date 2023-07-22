using System;
using System.Collections.Generic;

namespace OOPAdvanced.ex7
{
    public class Floor
    {
        private int floorNumber;
        public List<Room> Rooms { get; private set; }

        public Floor(int floorNumber)
        {
            this.floorNumber = floorNumber;
            Rooms = new List<Room>();
        }

        public int GetFloorNumber()
        {
            return floorNumber;
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}

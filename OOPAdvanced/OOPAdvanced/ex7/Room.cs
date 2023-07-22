using System;
namespace OOPAdvanced.ex7
{
    public abstract class Room : RectangularShape, ILoaction
    {
        private int row, column;

        public int Row { get { return row; } set { row = value; } }
        public int Column { get { return column; } set { column = value; } }

        public Room(int width, int height, int row, int column)
        {
            Width = width;
            Height = height;
            Row = row;
            Column = column;
        }
    }
}

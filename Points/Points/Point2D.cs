using System;
namespace Points
{
    public class Point2D
    {
        public int x;
        public int y;
        public Point2D()
        {
            x = 0;
            y = 0;
        }
        public Point2D(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }
        override
        public string ToString() 
        {
            return "(" + x + "," + y + ")";
        }
        override
        public bool Equals(Object o)
        {
            if(o is Point2D && ((Point2D)o).x == this.x && ((Point2D)o).y == this.y)
            {
                return true;
            }
            return false;
        }
    }
}

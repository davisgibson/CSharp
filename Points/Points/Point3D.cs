using System;
namespace Points
{
    public class Point3D : Point2D
    {
        public int z;
        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Point3D(int xVal, int yVal, int zVal)
        {
            x = xVal;
            y = yVal;
            z = zVal;
        }
        override
        public string ToString()
        {
            return "(" + x + "," + y + "," + z + ")";
        }
        public bool Equals(Object o)
        {
            if (o is Point3D && ((Point3D)o).x == this.x && ((Point3D)o).y == this.y && ((Point3D)o).z == this.z)
            {
                return true;
            }
            return false;
        }
    }
}

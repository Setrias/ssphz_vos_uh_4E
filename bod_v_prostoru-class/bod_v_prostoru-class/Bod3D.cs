using System;

namespace bod_v_prostoru_class
{
    public class Bod3D
    {
        private double sourX;
        private double sourY;
        private double sourZ;

        // constructor
        public Bod3D(double x, double y, double z)
        {
            sourX = x;
            sourY = y;
            sourZ = z;
        }

        public double VzdalenostOdPocatku()
        {
            return Math.Sqrt(Math.Pow(sourX, 2) + Math.Pow(sourY, 2));
        }
    }
}
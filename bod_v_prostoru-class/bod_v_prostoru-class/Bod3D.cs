using System;

namespace bod_v_prostoru_class
{
    public class Bod3D
    {
        private double sourX;
        private double sourY;
        private double sourZ;

        /// Konstruktor, má stejný název jako třída. Vytvoří se jako datový typ a uloží proměnné pro funkce definované ve třídě.
        public Bod3D(double x, double y, double z)
        {
            sourX = x;
            sourY = y;
            sourZ = z;
        }

        /// Funkce pro určení vzdálenosti od počátku (0; 0) v dvjorozměrném prostoru.
        public double VzdalenostOdPocatku()
        {
            return Math.Sqrt(Math.Pow(sourX, 2) + Math.Pow(sourY, 2));
        }

        /// Funkce pro určení vzdálenosti od počátku (0; 0; 0) v trojrozměrném prostoru.
        public double VzdalenostOdPocatku3D()
        {
            return Math.Sqrt(Math.Pow(sourX, 2) + Math.Pow(sourY, 2) + Math.Pow(sourZ, 2));
        }
    }
}
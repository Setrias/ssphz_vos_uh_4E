using System;

namespace Buchtík_2023_11_10_test
{
    public class Hranol
    {
        private double a, b, c, hustota;

        // inicializační funkce (constructor)
        public Hranol(double stranaA, double stranaB, double stranaC, double zadanaHustota)
        {
            a = stranaA;
            b = stranaB;
            c = stranaC;
            hustota = zadanaHustota;
        }

        // Výpočet objemu
        public double Objem()
        {
            return a * b * c;
        }

        // Výpočet obsahu
        public double Obsah()
        {
            return 2 * (Math.Pow(a, 2) * Math.Pow(b, 2) * Math.Pow(c, 2));
        }

        // Výpočet hmotnosti
        public double Hmotnost()
        {
            return Objem() * hustota;
        }
    }
}
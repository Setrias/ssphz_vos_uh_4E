using System;

namespace bod_v_prostoru_class
{
    public class KomplexniCislo
    {
        // datové složky
        private double Re;
        private double Im;

        // constructor
        public KomplexniCislo(double iRe, double iIm)
        {
            Re = iRe;
            Im = iIm;
        }

        // metody (funkce)
        public double UrciRe()
        {
            return Re;
        }

        public double UrciIm()
        {
            return Im;
        }

        public double UrciAbsHod()
        {
            return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2));
        }
    }
}
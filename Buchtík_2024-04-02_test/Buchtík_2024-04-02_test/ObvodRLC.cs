using System;

namespace Buchtík_2024_04_02_test
{
    public class ObvodRLC
    {
        private double R, L, C;

        public ObvodRLC(double iR, double iL, double iC)
        {
            R = iR;
            L = iL;
            C = iC;
        }

        public double Omega()
        {
            return Math.Sqrt(Math.Pow(OmegaNula(), 2) - Math.Pow(Delta(), 2));
        }

        public double OmegaNula()
        {
            return 1.0 / Math.Sqrt(L * C);
        }

        public double Delta()
        {
            return R / (2 * L);
        }
    }
}
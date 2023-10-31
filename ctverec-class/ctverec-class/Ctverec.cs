using System;

namespace ctverec_class
{
    public class Ctverec
    {
        private double delkaStrany;

        /// Zadaná délka strany
        /// >> obvod, obsah, úhlopříčka, kružnice opsaná, kružnice vepsaná
        public Ctverec(double delkaStrany)
        {
            this.delkaStrany = delkaStrany;
        }

        public double Obvod()
        {
            return delkaStrany * 4;
        }

        public double Obsah()
        {
            return delkaStrany * delkaStrany;
        }

        public double Uhlopricka()
        {
            return Math.Sqrt(Math.Pow(delkaStrany, 2) + Math.Pow(delkaStrany, 2));
        }

        public double KruzniceOpsana()
        {
            return Uhlopricka() / 2;
        }

        public double KruzniceVepsana()
        {
            return delkaStrany / 2;
        }
    }
}
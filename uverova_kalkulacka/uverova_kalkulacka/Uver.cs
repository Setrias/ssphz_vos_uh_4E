using System;

namespace uverova_kalkulacka
{
    public class Uver
    {
        // datove slozky
        private int pujcka, dobaSplaceni;

        // funkce
        public Uver(int iPujcka, int iDobaSplaceni)
        {
            pujcka = iPujcka;
            dobaSplaceni = iDobaSplaceni;
        }

        public int DobaSplaceni()
        {
            return dobaSplaceni;
        }

        public int VysePujcky()
        {
            return pujcka;
        }

        public int UrokovaSazba()
        {
            if (pujcka < 50000)
            {
                return 8;
            }

            if (pujcka > 50000 && pujcka < 250000)
            {
                return 6;
            }

            // nad 250,000.000;
            return 5;
        }

        public double Splatky()
        {
            int sazba = UrokovaSazba();
            double r = 1 + sazba / 100.0;
            return pujcka * (Math.Pow(r, dobaSplaceni) * ((r - 1) / (Math.Pow(r, dobaSplaceni) - 1)));
        }
    }
}
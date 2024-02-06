using System;

namespace slunecni_soustava
{
    public class Planety
    {
        private double obeznaDoba, r_AU, r_km, rychlostTelesa;

        public Planety(double iObeznaDoba)
        {
            obeznaDoba = iObeznaDoba;
        }

        public double VypisVzdalenostAu()
        {
            r_AU = Math.Pow(Math.Pow(obeznaDoba, 2), 1 / 3.0); // třetí odmocnina je x na 1/3
            return r_AU;
        }

        public double VypisVzdalenostKm()
        {
            r_km = Math.Pow(Math.Pow(obeznaDoba, 2), 1 / 3.0) * 149597871;
            return r_km;
        }

        public double PrumernaRychlostTelesa()
        {
            rychlostTelesa = (2 * Math.PI * r_km) / obeznaDoba;
            return rychlostTelesa;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Tlumeni_RLC_obvodu
{
    public class Vypocty
    {
        private double odpor, indukcnost, kapacita, fi, amplituda, cas;

        public Vypocty(double iOdpor, double iIndukcnost, double iKapacita, double iFi, double iAmplituda, double cas)
        {
            odpor = iOdpor;
            indukcnost = iIndukcnost;
            kapacita = iKapacita;
            fi = iFi;
            amplituda = iAmplituda;
        }

        public double Tlumeni()
        {
            return odpor / 2 * indukcnost;
        }

        public double OmegaNula()
        {
            return 1 / Math.Sqrt(indukcnost * kapacita);
        }

        public double Omega()
        {
            return Math.Sqrt(Math.Pow(OmegaNula(), 2) - Math.Pow(Tlumeni(), 2));
        }

        public double OkamzitaHodnotaProudu()
        {
            return amplituda * Math.Exp(-Tlumeni() * cas) * Math.Cos(Omega() * cas + fi);
        }
    }
}
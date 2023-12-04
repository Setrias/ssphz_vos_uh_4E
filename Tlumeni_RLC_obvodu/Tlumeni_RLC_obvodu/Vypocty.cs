using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tlumeni_RLC_obvodu
{
    public class Vypocty
    {
        private double odpor, indukcnost, kapacita, fi, amplituda;
        private double tlumeni, omega0, omega;

        public Vypocty(double iOdpor, double iIndukcnost, double iKapacita, double iFi, double iAmplituda)
        {
            odpor = iOdpor;
            indukcnost = iIndukcnost;
            kapacita = iKapacita;
            fi = iFi;
            amplituda = iAmplituda;

            tlumeni = odpor / (2.0 * indukcnost);
            omega0 = 1 / Math.Sqrt(indukcnost * kapacita);
            omega = Math.Sqrt(Math.Pow(omega0, 2) - Math.Pow(tlumeni, 2));
        }

        public double Tlumeni()
        {
            return tlumeni;
        }

        public double OmegaNula()
        {
            return omega0;
        }

        public double Omega()
        {
            return omega;
        }

        public double OkamzitaHodnotaProudu(double cas)
        {
            // je to '/' protože tlumení je kladné, jinak je to ten vzorec '*' když je tlumení záporné
            return amplituda / Math.Exp(tlumeni * cas) * Math.Cos(omega * cas + fi);
        }
    }
}
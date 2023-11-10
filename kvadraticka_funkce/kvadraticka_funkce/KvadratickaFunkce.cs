using System.Drawing;
using System.Windows.Forms;

namespace kvadraticka_funkce
{
    public class KvadratickaFunkce
    {
        public KvadratickaFunkce()
        {
        }

        public void OsaGrafu(float width, float height, Graphics panel)
        {
            // vertikální
            panel.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
            // horizontální
            panel.DrawLine(Pens.Black, 0, height / 2, width, height / 2);
        }
    }
}
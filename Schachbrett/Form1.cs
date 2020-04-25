using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schachbrett
{
    public partial class frmSchachbrett : Form
    {
        public frmSchachbrett()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ZeichneSchachbrett();
        }

        private void ZeichneSchachbrett()
        {
            int x;
            int y;
            int anzahl;
            int breite;
            int hoehe;
            Label lbl;

            pnlSchachbrett.Controls.Clear();
            anzahl = Convert.ToInt32(nudAnzahlZeilen.Value);

            breite = pnlSchachbrett.Width / anzahl;
            hoehe = pnlSchachbrett.Height / anzahl;

            for (y = 0; y < anzahl; y++)
            {
                for (x = 0; x < anzahl; x++)
                {
                    if (((x + y) % 2) == 0)
                    {
                        lbl = new Label();
                        lbl.Location = new Point(x * breite, y * hoehe);
                        lbl.Size = new Size(breite, hoehe);
                        lbl.BackColor = Color.Black;
                        pnlSchachbrett.Controls.Add(lbl);
                    }
                }
            }
        }
    }
}

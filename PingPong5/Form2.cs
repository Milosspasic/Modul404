using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();

            try
            {
                lblErgebnisse.Text = File.ReadAllText("Hiscore.txt");
            }
            catch (FileNotFoundException)
            {
                lblErgebnisse.Text = "";
            }
        }

        public void SetPunkte(int punkte)
        {
            lblPunkte.Text = punkte.ToString();
        }

        private void btnEintragen_Click(object sender, EventArgs e)
        {
            string zeile = String.Format("{0}    {1}    {2}\n", lblPunkte.Text, txtName.Text, DateTime.Now.Date.ToString());

            lblErgebnisse.Text += zeile;

            File.WriteAllText("Hiscore.txt", lblErgebnisse.Text);
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

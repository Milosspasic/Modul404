using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmPingPong : Form
    {
        public frmPingPong()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.Load += FrmPingPong_Load;

            dx = 5;
            dy = 2;
            punkte = 0;
            txtPunkte.Text = "0";

            form2 = new frmGameOver();

            lstRichtungsButton = new List<Button>();
            lstRichtungsButton.Add(btnHoch);
            lstRichtungsButton.Add(btnRunter);
            lstRichtungsButton.Add(btnLinks);
            lstRichtungsButton.Add(btnRechts);

            rdbSchlaeger.Checked = true;
        }

        private void FrmPingPong_Load(object sender, EventArgs e)
        {
            vsbSchlaegerRechts.Maximum = pnlSpiel.Height - 40;
            picSchlaegerRechts.Location = new Point(pnlSpiel.Width - 4, vsbSchlaegerRechts.Value);
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            int x = picBall.Location.X;
            int y = picBall.Location.Y;

            x += dx;
            y += dy;

            if (x < 0)
            {
                dx = -dx;
                x = -x;
            }
            if (x > (pnlSpiel.Width - 25))
            {
                if (y >= (picSchlaegerRechts.Location.Y - picBall.Height) && y <= (picSchlaegerRechts.Location.Y + picSchlaegerRechts.Height))
                {
                    dx = -dx;
                    x = 2 * (pnlSpiel.Width - 25) - x;
                    punkte += 10;
                    txtPunkte.Text = punkte.ToString();

                    if (rdbBall.Checked)
                    {
                        int sy = GeneriereZufallszahl(pnlSpiel.Height - 40);
                        picSchlaegerRechts.Location = new Point(picSchlaegerRechts.Location.X, sy);
                    }
                }
                else
                {
                    tmrSpiel.Stop();
                    form2.SetPunkte(punkte);
                    form2.Visible = true;
                }
            }
            if (y < 0)
            {
                dy = -dy;
                y = -y;
            }
            if (y > (pnlSpiel.Height - 25))
            {
                dy = -dy;
                y = 2 * (pnlSpiel.Height - 25) - y;
            }

            picBall.Location = new Point(x, y);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
            punkte = 0;
            txtPunkte.Text = "0";
        }

        private int dx;
        private int dy;
        private int punkte;

        private void vsbSchlaegerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlaegerRechts.Location = new Point(picSchlaegerRechts.Location.X, e.NewValue);
        }

        private void btnUDLR_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            versetzeBall(btn.Tag.ToString());
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                versetzeBall("ho");
                return true;
            }
            else if (keyData == Keys.Down)
            {
                versetzeBall("ru");
                return true;
            }
            else if (keyData == Keys.Left)
            {
                versetzeBall("li");
                return true;
            }
            else if (keyData == Keys.Right)
            {
                versetzeBall("re");
                return true;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        void versetzeBall(string tag)
        {
            switch (tag)
            {
                case "ho":
                    picBall.Location = new Point(picBall.Location.X, picBall.Location.Y - 25);
                    break;
                case "ru":
                    picBall.Location = new Point(picBall.Location.X, picBall.Location.Y + 25);
                    break;
                case "li":
                    picBall.Location = new Point(picBall.Location.X - 25, picBall.Location.Y);
                    break;
                case "re":
                    picBall.Location = new Point(picBall.Location.X + 25, picBall.Location.Y);
                    break;
            }
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.H:
                    dx = -dx;
                    break;
                case Keys.V:
                    dy = -dy;
                    break;
                case Keys.P:
                    tmrSpiel.Stop();
                    break;
                case Keys.S:
                    tmrSpiel.Start();
                    break;
                default:
                    break;
            }
        }

        readonly frmGameOver form2;

        private void rdbBall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBall.Checked)
            {
                rdbSchlaeger.Checked = false;

                vsbSchlaegerRechts.Enabled = false;

                foreach (Button b in lstRichtungsButton)
                    b.Enabled = true;
            }
        }

        private void rdbSchlaeger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSchlaeger.Checked)
            {
                rdbBall.Checked = false;

                vsbSchlaegerRechts.Enabled = true;

                foreach (Button b in lstRichtungsButton)
                    b.Enabled = false;
            }
        }

        int GeneriereZufallszahl(int max)
        {
            return rnd.Next(0, max);
        }

        List<Button> lstRichtungsButton;
        readonly Random rnd = new Random();
    }
}

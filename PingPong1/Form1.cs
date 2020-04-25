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

            dx = 5;
            dy = 2;
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
                dx = -dx;
                x = 2 * (pnlSpiel.Width - 25) - x;
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
        }

        private int dx;
        private int dy;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PingPong
{
    class Zufallsmethoden
    {
        public int GeneriereZufallszahl(int max)
        {
            return rnd.Next(0, max);
        }

        public Color GeneriereZufallsfarbe()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        readonly Random rnd = new Random();
    }
}

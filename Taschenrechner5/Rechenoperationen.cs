using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Rechenoperationen
    {
        public double Addition(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }

        public double Subtraktion(double zahl1, double zahl2)
        {
            return zahl1 - zahl2;
        }

        public double Mittelwert(double zahl1, double zahl2)
        {
            return (zahl1 + zahl2) / 2;
        }

        public double Potenz(double basis, double exponent)
        {
            return Math.Pow(basis, exponent);
        }

        public double Maximum(double zahl1, double zahl2)
        {
            return (zahl1 < zahl2) ? zahl2 : zahl1;
        }
    }
}

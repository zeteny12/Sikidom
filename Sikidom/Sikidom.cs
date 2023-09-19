using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Sikidom
    {
        public string Nev;
        public double AOldal;
        public double BOldal;
        public double Kerulet;
        public double Terulet;
        public double Sugar;

        public Sikidom(string nev, double aOldal, double bOldal, double kerulet, double terulet, double sugar)
        {
            this.Nev = nev;
            this.AOldal = aOldal;
            this.BOldal = bOldal;
            this.Kerulet = kerulet;
            this.Terulet = terulet;
            this.Sugar = sugar;
        }
    }
}

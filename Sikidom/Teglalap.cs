using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Teglalap : Sikidom
    {
        public Teglalap() 
            : base("Téglalap", 22.1, 12.4, 2*(22.1+12.4), 22.1*12.4, 0)
        {
        }
    }
}

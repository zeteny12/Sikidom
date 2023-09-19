using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Itthon még átnéztem párszor, és próbálgattam, lehet félreértettem a feladatot
            
            List<Sikidom> sikidom = new List<Sikidom>();

            sikidom.Add(new Teglalap());
            sikidom.Add(new Negyzet());
            sikidom.Add(new Kor());

            foreach (var item in sikidom)
            {
                Console.WriteLine(item.Nev + " kerülete: " + item.Kerulet + " m^2 ,a területe pedig: " + item.Terulet + " m^3");
            }


            Console.ReadKey();
        }
    }
}

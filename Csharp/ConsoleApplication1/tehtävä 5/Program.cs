using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit: ");
            int syote = int.Parse(Console.ReadLine());

            int tunti = (syote / 3600);
            int s_jakojaannos = (syote % 3600);
            int minuutti = (s_jakojaannos / 60);
            int sekuntti = (syote % 60);

            Console.WriteLine(tunti + "tuntia " + minuutti + "minuuttia " + sekuntti + "sekunttia");
        }
    }
}

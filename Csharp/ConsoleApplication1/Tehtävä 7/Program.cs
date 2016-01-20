using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosiluku: ");
            string rivi = Console.ReadLine();
            int vuosi = int.Parse(rivi);

            if (vuosi % 4 == 0 && vuosi % 100 != 0)
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            } else {
                Console.WriteLine("Vuosi ei ole karkausvuosi");

            }
        }
    }
}

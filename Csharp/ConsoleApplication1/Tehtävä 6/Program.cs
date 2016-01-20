using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna matka: ");
            double syote = double.Parse(Console.ReadLine());

            double kulutus = (7.02 / 100 * syote);
            double hinta = (1.595 * kulutus);

            Console.WriteLine("Bensan kulutus: " + kulutus + "ja hinta: " + hinta);
        }
    }
}

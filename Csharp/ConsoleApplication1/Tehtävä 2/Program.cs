using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tee ohjelma, jossa annetaan oppilaalle koulunumero
seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)*/

namespace Tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pistemäärä 0-12: ");
            string rivi = Console.ReadLine();
            int luku = int.Parse(rivi);
            
            if (luku == 0 || luku == 1)
            {
                Console.WriteLine("Koulunumerosi on 0");
            } else if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Koulunumerosi on 1");
            } else if(luku == 4 || luku == 5)
            {
                Console.WriteLine("Koulunumerosi on 2");
            } else if (luku == 6 || luku ==7)
            {
                Console.WriteLine("Koulunumerosi on 3");
            } else if (luku ==8 || luku ==9)
            {
                Console.WriteLine("Koulunumerosi on 4");
            } else if (luku == 10 || luku == 11 || luku ==12)
            {
                Console.WriteLine("Koulunumerosi on 5");
            }
            
        }
    }
}

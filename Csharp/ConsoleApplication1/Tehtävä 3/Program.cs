using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ensimmäinen luku: ");
            string rivi1 = Console.ReadLine();
            int luku1= int.Parse(rivi1);

            Console.WriteLine("Anna toinen luku: ");
            string rivi2 = Console.ReadLine();
            int luku2 = int.Parse(rivi2);

            Console.WriteLine("Anna kolmas luku: ");
            string rivi3 = Console.ReadLine();
            int luku3 = int.Parse(rivi3);


            Console.WriteLine("Syötit luvut:" +luku1 +" " +luku2 +" " +luku3);
            int summa = luku1 + luku2 + luku3;
            int keskia = summa/3;
            Console.WriteLine("Lukujen yhteenlaskettu summa on: " + summa);
            Console.ReadLine();
            Console.WriteLine("Lukujen keskiarvo on: " + keskia);
            Console.WriteLine();

        }
    }
}

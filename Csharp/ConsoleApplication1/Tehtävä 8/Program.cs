using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen luku: ");
            string rivi1 = Console.ReadLine();
            int luku1 = int.Parse(rivi1);

            Console.Write("Anna toinen luku: ");
            string rivi2 = Console.ReadLine();
            int luku2 = int.Parse(rivi2);

            Console.Write("Anna kolmas luku: ");
            string rivi3 = Console.ReadLine();
            int luku3 = int.Parse(rivi3);

            if (luku1 > luku2 && luku2 > luku3)
            {
                Console.WriteLine(luku1);
            }

            else if (luku1 < luku2 && luku2 > luku3)
            {
                Console.WriteLine(luku2);
            }

            else if (luku1 < luku2 && luku2 < luku3)
            {
                Console.WriteLine(luku3);
            }

            else if (luku1 > luku2 && luku1 < luku3)
            {
                Console.WriteLine(luku3);
            }

            else if (luku1 > luku3 && luku1 > luku2)
            {
                Console.WriteLine(luku1);
            }

        }
    }
}

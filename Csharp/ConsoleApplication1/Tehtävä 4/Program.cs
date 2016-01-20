using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi: ");
            string rivi = Console.ReadLine();
            int ika = int.Parse(rivi);

            if (ika <= 17)
            {
                Console.WriteLine("Olet alaikäinen");
                Console.ReadLine();
            } else if (ika >=17 && ika <= 64)
            {
                Console.WriteLine("Olet aikuinen");
                Console.ReadLine();
            } else if (ika > 64)
            {
                Console.WriteLine("Seniori");
                Console.ReadLine();
            }
        }
    }
}

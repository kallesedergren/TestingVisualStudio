using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Anna *-merkkien määrä: ");
            Console.ReadLine(); */
            int k;
            int stars = 10;
            for (int i = 1; i <= stars; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    
                    
                }
            }
        }
    }
}

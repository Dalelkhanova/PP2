using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // To limit out array 

            /* 11 12 13     [*]  .   .
             * 21 22 23 ->  [*]  [*] .
             * 31 32 33     [*]  [*]                   */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("[*]");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
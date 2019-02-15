using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();


            int aa = int.Parse(a);//преобразую переменную типа строка в целое число
            string[] parts = b.Split();//разделение на пробелы второй строки 

            for (int i = 0; i < parts.Length; ++i)
            {
                int x = int.Parse(parts[i]);
                for (int j = 1; j <= 2; ++j)
                {
                    Console.Write(x + " ");//вывожу числа массива
                }
            }
            Console.ReadKey();

        }
    }
}
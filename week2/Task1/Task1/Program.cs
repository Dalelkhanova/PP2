using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("palindromornot.txt"); //Reading data from file

            char[] reversed = text.ToCharArray();                    //Splitting every letter of data(string)

            Array.Reverse(reversed);                                //reversing all of chars from begin to end

            string reversed_string = new string(reversed);             //making string from that reversed chars

            if (reversed_string == text)
                Console.WriteLine("Yes");            //If it is look alike our initial string then it is palindrom
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
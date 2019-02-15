using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool Prime(int n)    //method to check prime numbers       
        {
            if (n == 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string data = File.ReadAllText("primeornot.txt");            //Reading data from txt file

            StreamWriter answer = new StreamWriter("answer.prime.txt");  //Declaration of file "answer"

            string[] numbers = data.Split(' ');              //splittin array from numbers with "space"


            int[] nn = Array.ConvertAll(numbers, int.Parse);            
            int n = nn.Length;               //counted numbers from array

            int[] s = new int[n];                                       //limited array

            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(numbers[i]);
                if (Prime(s[i])) answer.Write(s[i] + " ");    //Calling function to check number for prime criteries
            }

            answer.Close();
        }
    }
}
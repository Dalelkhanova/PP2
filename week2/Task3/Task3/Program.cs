using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Printspaces(int lvl)            //Find depth of directory(tree)

        {
            for (int i = 0; i < lvl; i++)
                Console.Write(" ");
        }
        static void task(DirectoryInfo directory, int lvl)      //Method with 2 parameters
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (FileInfo file in files)
            {
                Printspaces(lvl);                           //Calling method to divide strings with space 
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo d in directories)
            {
                Printspaces(lvl);                             //Calling method to divide strings with space
                Console.WriteLine(d.Name);
                task(d, lvl + 5);                             //Calling again method task()- recursive
            }

        }
        static void Main(string[] args)

        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\admin\Desktop\Test"); //Giving path 
            task(d, 1);                                                         //Calling method task();
            Console.ReadKey();

        }
    }
}
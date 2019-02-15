using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string fileName = "asdf.txt";                            
             string sourcePath = @"C:\Users\admin\Desktop\Test\DAR\File1\qwerty";
             string targetPath = @"C:\Users\admin\Desktop\Test\DAR\File2";

             string sourceFile = Path.Combine(sourcePath, fileName);    //Method to make computer understand which of them needs to be copied to another directory
             string destFile = Path.Combine(targetPath, fileName);

             File.Copy(sourceFile, destFile, true);                       //Method which copies file from one path to another
             File.Delete(@"C:\Users\admin\Desktop\Test\DAR\File1\qwerty\asdf.txt"); //which deletes first path*/

            string sourcePath = @"C:\Users\admin\Desktop\Test\DAR\File1\qwerty\asdf.txt";
            string targetPath = @"C:\Users\admin\Desktop\Test\DAR\File2\asdf.txt";
            File.Copy(sourcePath, targetPath);
            File.Delete(@"C:\Users\admin\Desktop\Test\DAR\File1\qwerty\asdf.txt");

        }
    }
}

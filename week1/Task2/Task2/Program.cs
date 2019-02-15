using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        string name; //items of class
        string id;
        int year = 2018;

        public Student(string name, string id)    //constructor with two parameters 
        {
            this.name = name;
            this.id = id;
        }

        public void Printing()  //method, prints name and id

        {
            Console.Write(name + " " + id + " ");
        }

        public void Yearprint() //method, prints increment of year
        {
            year++;
            Console.Write(year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student("Aigerim", "18BD110725"); //object

            x.Printing(); //calling method
            x.Yearprint();//calling method

            Console.ReadKey();
        }
    }
}
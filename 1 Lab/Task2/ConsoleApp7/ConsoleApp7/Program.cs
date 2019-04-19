using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Vasya", "Petrov");//creates new variable of class student
            st1.PrintID();
            st1.PrintName();
            st1.PrintYear();
            st1.IncrYear();
            st1.PrintYear();
            Console.ReadKey();            
        }
    }
    public class Student
    {
        public string Name, ID;
        public int year;
        public Student (string name, string id, int year = 1)
        {
            Name = name;
            ID = id;
            this.year = year;
        }
        public int adad()
        {
            return 1;
        }
        public void PrintName()//Writes name of the student to the console
        {
            Console.WriteLine(Name);
        }
        public void PrintID()//writes  ID of the student ot the console
        {
            Console.WriteLine(ID);
        }
        public void PrintYear()//writes year of the student to the console
        {
            Console.WriteLine(year);
        }
        public void IncrYear()//function to increment year
        {
            year++;
            return;
        }


}

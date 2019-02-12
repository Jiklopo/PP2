using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Student
    {
        public string Name, ID;
        public int year;
        public Student (string name, string id)
        {
            Name = name;
            ID = id;
            year = 2019;
        }
        public string PrintName()
        {
            return Name;
        }
        public string PrintID()
        {
            return ID;
        }
        public int PrintYear()
        {
            return year;
        }
        public void IncrYear()
        {
            year++;
            return;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

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
        public static bool Is_Prime(int a)//function to check if number is prime
        {
            if (a == 1)
                return false;
            for(int i=2; i<=a/2; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            int a;
            string s = File.ReadAllText(@"..\..\input.txt");
            string[] s1 = s.Split(' ');
            foreach(string s2 in s1)
            {
                a = int.Parse(s2);
                if (Is_Prime(a))
                    File.AppendAllText(@"..\..\output2.txt", s2 + ' ');
            }
         

        }
    }
}

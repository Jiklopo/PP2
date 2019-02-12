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
        public static bool Is_Prime(int a)
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
            string s = System.IO.File.ReadAllText(@"..\..\input.txt");
            System.IO.File.WriteAllText(@"..\..\output.txt", "");
            string[] sa = s.Split(' ');
            int[] asd = new int[sa.Length];
            for(int i=0; i<sa.Length; i++)
            {
                a = int.Parse(sa[i]);
                if (Is_Prime(a))
                    System.IO.File.AppendAllText(@"..\..\output.txt", a + " ");
            }
            Console.ReadKey();

        }
    }
}

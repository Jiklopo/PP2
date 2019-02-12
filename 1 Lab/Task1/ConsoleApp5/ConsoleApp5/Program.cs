using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];//creating an array
            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());//filling an array
            }
            for (int i = 0; i<n; i++)
            {
                bool IsPrime = true;
                for(int j=2; j<a[i]; j++)
                {
                    if (a[i] % j == 0 || a[i] == 1) //to check if number is prime or not we check if  it is divisible by each number which is less than it
                    {
                        IsPrime = false;//if it is divisible by some number it means that it is not prime
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write(a[i]);// if number is prime we show it
                    Console.Write(" ");
                }
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] array = new string[n, n]; //creating 2d array
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<=i; j++)//The amount of stars on each row is equal to the numnber of row so j is less or equal than i
                {
                    array[i, j] = "[*]";//we put a star where we need to
                    Console.Write(array[i, j]);//we show this star
                }
                Console.WriteLine();//changing lines
            }
            Console.Read();
        }
    }
}

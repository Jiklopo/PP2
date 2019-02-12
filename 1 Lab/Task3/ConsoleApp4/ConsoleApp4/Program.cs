using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            int[] array = new int[n]; //creating an array
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); //writing in an array
            }
            for(int i=0; i<n; i++)
            {
                Console.Write(array[i]);//show element of the array
                Console.Write(" ");
                Console.Write(array[i]);//show element of the array for the second time
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}

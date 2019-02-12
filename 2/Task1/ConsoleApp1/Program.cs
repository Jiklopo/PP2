using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"..\..\input.txt");//gets string from file
            bool Is_Palindrom = true;
            for (int i=0; i<text.Length; i++)//checks if it is palindrom
            {
                if(text[i]!=text[text.Length - 1 - i])
                {
                    Is_Palindrom = false;
                    break;
                }
            }
            if (Is_Palindrom)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

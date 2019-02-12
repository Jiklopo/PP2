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
           static void Space_created(int a)
            //Function that prints needed amount of spaces to indicate level
            {
                for(int i=0; i<a; i++)
                {
                    Console.Write("   ");
                }
            }

        static void PrintDirectories(DirectoryInfo path, int cnt = 0)
        {
            DirectoryInfo[] Dirs = path.GetDirectories();
            //We get the list of directories in current directory
            FileInfo[] Files = path.GetFiles();
            //We get the list of files in current directory
                for (int i=0; i<Dirs.Length; i++)
                {
                    Space_created(cnt);
                    Console.WriteLine(Dirs[i].Name);
                    PrintDirectories(Dirs[i], cnt+1);
                //We print names of all directories in current directory and use our function to show what is inside these directories
                }
                for(int i=0; i<Files.Length; i++)
                {
                    Space_created(cnt);
                    Console.WriteLine(Files[i].Name);
                //Then print names of all the files
                }
            if (Dirs.Length != 0 && Files.Length != 0)
            {
                return;
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo(@"J:\Библиотеки\Документы\c++");
            PrintDirectories(path);
            Console.ReadKey();
        }
    }
}

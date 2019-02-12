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
            {
                for(int i=0; i<a; i++)
                {
                    Console.Write("   ");
                }
            }

        static void PrintDirectories(DirectoryInfo path, int cnt = 0)
        {
            DirectoryInfo[] Dirs = path.GetDirectories();
            FileInfo[] Files = path.GetFiles();
            //while (Dirs.Length != 0 && Files.Length!=0)
            //{
                for (int i=0; i<Dirs.Length; i++)
                {
                    Space_created(cnt);
                    Console.WriteLine(Dirs[i].Name);
                    PrintDirectories(Dirs[i], cnt+1);
                }
                for(int i=0; i<Files.Length; i++)
                {
                    Space_created(cnt);
                    Console.WriteLine(Files[i].Name);
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

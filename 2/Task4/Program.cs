using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = System.IO.Path.GetRandomFileName();//generate random file name
            string path = System.IO.Path.Combine(@"..\..", filename);//make a path to this file
            string path1 = @"J:\Библиотеки\Документы\с#\2\Task4\Files\";//path where we going to move our file
            FileStream file = System.IO.File.Create(path);// creates a file
            file.Close();//closes and saves the file so that we can have access to it
            System.IO.File.Copy(path, path1 + filename);//copies file to path1
            System.IO.File.Delete(path);//deletes old file
            Console.ReadKey();
        }
    }
}

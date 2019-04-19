using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarManager
{
    public class Utilities
    {
        public static void Remove(string path)//function to delete folders
        {
            bool Is_Deleted = false;
            try//tries to delete folder if it is empty
            {
                Directory.Delete(path);
                Is_Deleted = true;
            }
            catch //if did not delete the folder it deletes everything inside
            {
                DirectoryInfo Dir = new DirectoryInfo(path);//we do this to get information about files inside the folder we want to delete
                foreach (DirectoryInfo a in Dir.GetDirectories())
                {
                    Remove(a.FullName);//if it is a directory we use function again
                }
                foreach (FileInfo file in Dir.GetFiles())
                {
                    File.Delete(file.FullName);//just delets it if it is a file
                }
            }
            finally//after deleting everything inside and folder is not deleted it delets the folder
            {
                if (!Is_Deleted)
                    Directory.Delete(path);
            }
        }




        public static void Cleaner()//cleans console
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }



        public static FileSystemInfo[] Sorter9000(FileSystemInfo[] a)//function to sort directories and files
        {
            bool Continue = true;
            FileSystemInfo temp;
            while (Continue)
            {
                Continue = false;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i].GetType() == typeof(DirectoryInfo) && a[i - 1].GetType() == typeof(FileInfo))//checks two elements and changes places
                    {//                                                                                 so directory will be first
                        temp = a[i];
                        a[i] = a[i - 1];
                        a[i - 1] = temp;
                        Continue = true;
                    }
                }
            }
            return a;
        }
    }
}

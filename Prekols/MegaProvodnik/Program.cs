using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace _3
{
    public class Provodnik
    {
        int cursor;
        static DirectoryInfo CurrentDir;
        public static  List<FileSystemInfo> vse;
        string what_to_move = "";
        string where_to_move = "";
        string name_to_move = "";
        bool To_Move_Or_Not_to_Move = false;

        

        public Provodnik()//constructor with default path
        {
            CurrentDir = new DirectoryInfo(@"J:\Библиотеки\Документы");
            vse.AddRange(CurrentDir.GetFileSystemInfos());
            vse.Sort(Comparator9000);
        }
        Provodnik(string path)//Constructor with custom path
        {
            CurrentDir = new DirectoryInfo(path);
            vse = Sort_Directories_Files(CurrentDir.GetFileSystemInfos());
        }
        


        public void Start()
        {
            while (true)
            {
                Show();//Shows contents of the folder
                ConsoleKeyInfo key = Console.ReadKey();//reads a key to know what to do next
                if (key.Key == ConsoleKey.Escape)
                {
                    break;//quits the loop and porgram ends
                }
                else if (key.Key == ConsoleKey.DownArrow)//moves cursor down
                {
                    cursor++;
                    if (cursor == vse.Count)
                        cursor = 0;
                }
                else if (key.Key == ConsoleKey.UpArrow)//moves cursor up
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = vse.Count - 1;
                }
                else if (key.Key == ConsoleKey.Backspace)//changes current directory to upper directory
                {
                    cursor = 0;
                    CurrentDir = new DirectoryInfo(CurrentDir.Parent.FullName);//upper directory is parent so we change our path to the parrent
                }
                else if (key.Key == ConsoleKey.Enter)//Enters selected directory or opens file
                {
                    if (vse[cursor].GetType() == typeof(DirectoryInfo))//changes current directory if selected item is a folder
                    {
                        CurrentDir = new DirectoryInfo(vse[cursor].FullName);
                        cursor = 0;
                    }
                    else//opens a file
                    {
                        Cleaner();
                        string ext = Path.GetExtension(vse[cursor].FullName);
                        if (ext == ".txt")// if this is a text it gets its contents and prints it
                        {
                            string content = File.ReadAllText(vse[cursor].FullName);
                            Console.WriteLine(content);
                        }
                        else if (ext == ".jpeg")//Work in progress
                        {

                        }
                        Console.ReadKey();
                    }

                }
                else if (key.Key == ConsoleKey.F2)//renames file or directory
                {
                    Cleaner();
                    string name = Console.ReadLine();//gets the future name of the file/directory
                    string path = Path.GetDirectoryName(vse[cursor].FullName);
                    if (vse[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Move(vse[cursor].FullName, Path.Combine(path, name));//just move it to the same directory with name changing
                    }
                    else
                    {
                        string ext = Path.GetExtension(vse[cursor].FullName);//get file's extension to add it later
                        File.Move(vse[cursor].FullName, Path.Combine(path, name + ext));//combines current path, new file name and extension;
                    }

                    cursor = 0;
                }
                else if (key.Key == ConsoleKey.F5)//continues loop to refresh
                    continue;
                else if (key.Key == ConsoleKey.Delete)//function to delete file
                {
                    if (vse[cursor].GetType() == typeof(FileInfo))
                        File.Delete(vse[cursor].FullName);//if it is a file it just deletes it
                    else
                    {
                        Remove(vse[cursor].FullName);//if it is directory initialize a function
                    }
                }
                else if (key.Key == ConsoleKey.M)//Work in progress
                {
                    if (!To_Move_Or_Not_to_Move)
                    {
                        string name_to_move = vse[cursor].Name;
                        what_to_move = vse[cursor].FullName;
                        To_Move_Or_Not_to_Move = true;
                    }
                    else if (To_Move_Or_Not_to_Move)
                    {
                        where_to_move = Path.Combine(CurrentDir.FullName, name_to_move);
                        File.Move(what_to_move, where_to_move);
                        To_Move_Or_Not_to_Move = false;
                    }

                }
            }
        }




        public void Show()//function to show all directories and files in the current folder
        {
            Cleaner();
            vse = Sort_Directories_Files(CurrentDir.GetFileSystemInfos());//get list of files and directories in current folder
            for (int i = 0; i < vse.Count; i++)//checks every item in vse to color console
            {
                if (i == cursor)//colors selected item
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (vse[i].GetType() == typeof(DirectoryInfo))//colors folder
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else // colors files
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine(vse[i]);//print name of the file/directory
            }
        }




        public void Remove(string path)//function to delete folders
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




        public void Cleaner()//cleans console
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }



        public int Comparator9000(FileSystemInfo a, FileSystemInfo b)
        {
            if (a.GetType() == typeof(DirectoryInfo))
            {
                if (b.GetType() == typeof(DirectoryInfo))
                    return 0;
                else
                    return 1;
            }
            else if (a.GetType() == typeof(FileInfo))
            {
                if (b.GetType() == typeof(DirectoryInfo))
                    return -1;
                else
                    return 0;
            }
            return 0;
        }



        public List<FileSystemInfo> Sort_Directories_Files(FileSystemInfo[] fileSystemInfos)//Function that returns sorted list of directories and files
        {
            List<FileSystemInfo> SupetList = new List<FileSystemInfo>();
            foreach(FileSystemInfo i in fileSystemInfos)//Firstly, we add directories
            {
                if (i.GetType() == typeof(DirectoryInfo))
                    SupetList.Add(i);
            }
            foreach (FileSystemInfo i in fileSystemInfos)//Then we add Files
            {
                if (i.GetType() == typeof(FileInfo))
                    SupetList.Add(i);
            }
            return SupetList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Provodnik exe = new Provodnik();
            exe.Start();
        }
    }
}
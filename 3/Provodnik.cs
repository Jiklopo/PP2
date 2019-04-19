using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
namespace FarManager
{
    public class Provodnik
    {
        int cursor;
        Color CurColor;
        int R, G, B;
        DirectoryInfo dir;
        public static FileSystemInfo[] vse;
        public Provodnik(string path)//Constructor with custom path
        {
            try
            {
                dir = new DirectoryInfo(path);
            }

            catch
            {
                dir = new DirectoryInfo(@"J:\Библиотеки\Документы");
            }
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
                    if (cursor == vse.Length)
                        cursor = 0;
                }

                else if (key.Key == ConsoleKey.UpArrow)//moves cursor up
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = vse.Length - 1;
                }

                else if (key.Key == ConsoleKey.Backspace)//changes current directory to upper directory
                {
                    cursor = 0;
                    dir = new DirectoryInfo(dir.Parent.FullName);//upper directory is parent so we change our path to the parrent
                }

                else if (key.Key == ConsoleKey.Enter)//Enters selected directory or opens file
                {
                    if (vse[cursor].GetType() == typeof(DirectoryInfo))//changes current directory if selected item is a folder
                    {
                        dir = new DirectoryInfo(vse[cursor].FullName);
                        cursor = 0;
                    }

                    else//opens a file
                    {
                        FileOpener file = new FileOpener(vse[cursor].FullName);
                        file.Open();
                    }

                }

                else if (key.Key == ConsoleKey.F2)//renames file or directory
                {
                    Utilities.Cleaner();
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
                        Utilities.Remove(vse[cursor].FullName);//if it is directory initialize a function
                    }
                }
            }
        }




        public void Show()//function to show all directories and files in the current folder
        {
            Utilities.Cleaner();
            vse = dir.GetFileSystemInfos();//get list of files and directories in current folder
            vse = Utilities.Sorter9000(vse);
            R = 255;
            G = 255;
            B = 255;
            for (int i = 0; i < vse.Length; i++)//checks every item in vse to color console
            {
                G -= 10;
                Console.ForegroundColor = Color.FromArgb(R, G%255, B);
                if (i == cursor)
                    Console.BackgroundColor = Color.Wheat;
                if (vse[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine(vse[i] + " [" + new DirectoryInfo(vse[i].FullName).GetFileSystemInfos().Length + "]");
                }
                else
                {
                    Console.WriteLine(vse[i]);
                }
                Console.ResetColor();
            }
        }
    }
}

using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace FarManager
{
    class FileOpener
    {
        string Ext;
        FileInfo file;
        public FileOpener(string Path)
        {
            file = new FileInfo(Path);
            Ext = file.Extension;
        }

        public void Open()
        {
            switch (Ext)
            {
                case ".jpg":
                    Bitmap bitmap = new Bitmap(file.FullName);
                    //Console.SetWindowSize(bitmap.Width*2, bitmap.Height);
                    //Console.SetBufferSize(bitmap.Width*2, bitmap.Height);
                    Utilities.Cleaner();
                    for(int i=0; i<bitmap.Width; i++)
                    {
                        for(int j=0; j<bitmap.Height; j++)
                        {
                            Console.BackgroundColor = bitmap.GetPixel(i, j);
                            Console.SetCursorPosition(i, j);
                            Console.Write(" ");
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

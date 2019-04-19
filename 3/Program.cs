using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace FarManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string path = Console.ReadLine();
            Provodnik exe = new Provodnik(path);
            exe.Start();
        }
    }
}

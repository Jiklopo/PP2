using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"J:\YandexDisk\Музыка\smb_mariodie.wav");
            sound.Play();
            Thread.Sleep(100000);
        }
    }
}

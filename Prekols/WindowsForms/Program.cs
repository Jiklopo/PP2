using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsForms
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureBox picture = new PictureBox();
            Bitmap bitmap = new Bitmap(Image.FromFile(@"J:\YandexDisk\Изображения\Jiklopo's sitckerpack\2MKxzhGcRv4.jpg"));
            picture.Image = bitmap;
            picture.ImageLocation = @"J:\YandexDisk\Изображения\Jiklopo's sitckerpack\2MKxzhGcRv4.jpg";
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            picture.Load();
        }
    }
}

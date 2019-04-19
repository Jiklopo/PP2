using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 5);
            oshirgish = new Pen(Color.White, 5);
            Vasek = new Secretar();
            CurvaPoints = new List<Point>();
            Instrument = Tool.Pencil;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Ecran.Width, Ecran.Height);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Ecran.Image = bitmap;
        }


        private void Ecran_Paint(object sender, PaintEventArgs e)
        {
            switch (Instrument)
            {
                case Tool.Pencil:
                    e.Graphics.DrawLine(pen, a, b);
                    a = b;
                    break;
                case Tool.Oshirgish:
                    e.Graphics.DrawLine(oshirgish, a, b);
                    a = b;
                    break;
                case Tool.Line:
                    e.Graphics.DrawLine(pen, a, b);
                    break;
                case Tool.Curve:
                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, r);
                    break;
                case Tool.FillEllipse:
                    e.Graphics.FillEllipse(pen.Brush, r);
                    break;
                case Tool.Rect:
                    e.Graphics.DrawRectangle(pen, r);
                    break;
                case Tool.FillRect:
                    e.Graphics.FillRectangle(pen.Brush, r);
                    break;
                case Tool.Star5:
                    e.Graphics.DrawPolygon(pen, Zvezda5(a, b));
                    break;
                case Tool.Star4:
                    e.Graphics.DrawPolygon(pen, Zvezda4(a, b));
                    break;
                default:
                    break;
            }
        }

        private void Nazhal(object sender, MouseEventArgs e)
        {
            a = e.Location;
        }

        private void Dvinul(object sender, MouseEventArgs e)
        {
            GdeYa.Text = e.Location.ToString();
            if(e.Button == MouseButtons.Left)
            {
                b = e.Location;
                r = Rectangulator(a, b);
                switch (Instrument)
                {
                    case Tool.Pencil:
                        g.DrawLine(pen, a, b);
                        a = b;
                        break;
                    case Tool.Oshirgish:
                        g.DrawLine(oshirgish, a, b);
                        a = b;
                        break;
                }
                Ecran.Refresh();
            }
        }

        private void Otpustil(object sender, MouseEventArgs e)
        {
            b = e.Location;
            r = Rectangulator(a, b);
            switch (Instrument)
            {
                case Tool.Line:
                    g.DrawLine(pen, a, b);
                    break;
                case Tool.Curve:
                    break;
                case Tool.Ellipse:
                    g.DrawEllipse(pen, r);
                    break;
                case Tool.FillEllipse:
                    g.FillEllipse(pen.Brush, r);
                    break;
                case Tool.Rect:
                    g.DrawRectangle(pen, r);
                    break;
                case Tool.FillRect:
                    g.FillRectangle(pen.Brush, r);
                    break;
                case Tool.Star5:
                    g.DrawPolygon(pen, Zvezda5(a, b));
                    break;
                case Tool.Star4:
                    g.DrawPolygon(pen, Zvezda4(a, b));
                    break;
                default:
                    break;
            }
            Ecran.Refresh();
        }

        private void Cvetik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            pen.Color = b.BackColor;
            CurColor.BackColor = b.BackColor;
        }

        private void VyborCveta_Click(object sender, EventArgs e)
        {
            Cvet.ShowDialog();
            pen.Color = Cvet.Color;
            CurColor.BackColor = Cvet.Color;
            if (!Vasek.VybCvet.Contains(Cvet.Color))
            {
                Vasek.Pokraska(Cvet.Color);
                Pokraska(Cvet.Color);
                Vasek.Sled();
            }
        }

        private void Instrumentik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Instrument = KakoiInstrum(b.Name);
            CurInstrum.Image = b.Image;
        }

        private void Razmer(object sender, EventArgs e)
        {
            pen.Width = int.Parse(Razmershik.Value.ToString());
            oshirgish.Width = int.Parse(Razmershik.Value.ToString());
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sohranyalka.ShowDialog();
            bitmap.Save(Sohranyalka.FileName);
        }

        private void Instuments_Enter(object sender, EventArgs e)
        {

        }

        private void Pokraska(Color cvet)
        {
            switch (Vasek.KakoiNomer)
            {
                case 0:
                    VybCvet1.BackColor = Vasek.VybCvet[0];
                    break;
                case 1:
                    VybCvet2.BackColor = Vasek.VybCvet[1];
                    break;
                case 2:
                    VybCvet3.BackColor = Vasek.VybCvet[2];
                    break;
                case 3:
                    VybCvet4.BackColor = Vasek.VybCvet[3];
                    break;
                default:
                    break;
            }
        }

        private void Ecran_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otkryvalka.ShowDialog();
            bitmap = new Bitmap(Otkryvalka.FileName);
            g = Graphics.FromImage(bitmap);
            Ecran.Image = bitmap;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            bitmap = new Bitmap(Ecran.Width, Ecran.Height);
            g = Graphics.FromImage(bitmap);
            Ecran.Image = bitmap;
            Ecran.Refresh();
        }
    }
}

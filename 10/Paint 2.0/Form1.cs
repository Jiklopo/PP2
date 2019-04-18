using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_2._0
{
    public partial class Form1 : Form
    {
        public static Thread ad;
        public static System.Drawing.Drawing2D.GraphicsContainer asd;
        public static Graphics g;
        public static System.Drawing.Drawing2D.GraphicsState gs;
        public static bool Is_Drawing, Is_Curve;
        public static Pen pen;
        public static SolidBrush brush;
        public static Secretar Vasek;
        public Point a, b;
        public List<Point> CurvaPoints;
        public Tool Instrument;
        public CurvaState curvastate;
        public enum Tool
        {
            Pencil,
            Oshirgish,
            Line,
            Curve,
            Ellipse,
            FillEllipse,
            Rect,
            FillRect
        }
        public enum CurvaState
        {
            NoCurva,
            Line,
            _1,
            _2
        }
        public Form1()
        {
            InitializeComponent();
            ad = new Thread(asdsad);
            pen = new Pen(Color.Black, 5);
            brush = new SolidBrush(Color.Black);
            Vasek = new Secretar();
            CurvaPoints = new List<Point>();
            Is_Drawing = false;
            Instrument = Tool.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Ecran_Paint(object sender, PaintEventArgs e)
        {
            g = Ecran.CreateGraphics();
        }

        private void Nazhal(object sender, MouseEventArgs e)
        {
            a = new Point(e.X, e.Y);
            Is_Drawing = true;
        }

        private void Dvinul(object sender, MouseEventArgs e)
        {
        }

        private void Otpustil(object sender, MouseEventArgs e)
        {
            ad.Abort();
            b = new Point(e.X, e.Y);
            Is_Drawing = false;
            Rectangle r = Vasek.Calculator9000(a, b);
            switch (Instrument)
            {
                case Tool.Pencil:
                    MessageBox.Show("asdasd");
                    break;
                case Tool.Oshirgish:
                    g.DrawPolygon(pen, Vasek.Zvezda2(a, b).ToArray());
                    break;
                case Tool.Line:
                    g.DrawLine(pen, a, b);
                    break;
                case Tool.Curve:
                    //CurvaPoints.Add(a);
                    //CurvaPoints.Add(b);
                    //CurvaPoints.Add(new Point(12, 15));
                    //g.DrawCurve(pen, CurvaPoints.ToArray());
                    switch (curvastate)
                    {
                        case CurvaState.NoCurva:
                            asd = g.BeginContainer();
                            gs = g.Save();
                            //g.DrawLine(pen, a, b);
                            CurvaPoints.Add(a);
                            CurvaPoints.Add(b);
                            curvastate = CurvaState.Line;
                            break;
                        case CurvaState.Line:
                            g.EndContainer(asd);
                            g.Restore(gs);
                            CurvaPoints.Add(b);
                            //g.DrawCurve(pen, CurvaPoints.ToArray());
                            curvastate = CurvaState._1;
                            break;
                        case CurvaState._1:
                            CurvaPoints.Add(b);
                            g.DrawCurve(pen, CurvaPoints.ToArray());
                            curvastate = CurvaState.NoCurva;
                            CurvaPoints.Clear();
                            break;
                        case CurvaState._2:
                            break;
                        default:
                            g.Save();
                            break;
                    }

                    break;
                case Tool.Ellipse:
                    g.DrawEllipse(pen, r);
                    break;
                case Tool.FillEllipse:
                    g.FillEllipse(brush, r);
                    break;
                case Tool.Rect:
                    g.DrawRectangle(pen, r);
                    break;
                case Tool.FillRect:
                    g.FillRectangle(brush, r);
                    break;
                default:
                    break;
            }
        }

        private void Cvetik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            pen.Color = b.BackColor;
            brush.Color = b.BackColor;
            CurColor.BackColor = b.BackColor;
        }

        private void VyborCveta_Click(object sender, EventArgs e)
        {
            Cvet.ShowDialog();
            pen.Color = Cvet.Color;
            brush.Color = Cvet.Color;
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
            Instrument = Vasek.KakoiInstrum(b.Name);
            CurInstrum.Image = b.Image;
        }

        private void Razmer(object sender, EventArgs e)
        {
            pen.Width = int.Parse(Razmershik.Value.ToString());
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            g.Save();
            //g.Restore(gs);
            Ecran.Image = new Bitmap(200, 200, g);
            Ecran.Image.Save(saveFileDialog1.FileName);
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

        private void asdsad()
        {
            if (Is_Drawing)
            {
                switch (Instrument)
                {
                    case Tool.Pencil:
                        break;
                    case Tool.Oshirgish:
                        break;
                    case Tool.Line:
                        g.DrawLine(pen, a, b);
                        break;
                    case Tool.Curve:
                        break;
                    case Tool.Ellipse:
                        break;
                    case Tool.FillEllipse:
                        break;
                    case Tool.Rect:
                        break;
                    case Tool.FillRect:
                        break;
                    default:
                        break;
                }
                g.Restore(gs);
            }
        }
    }
}

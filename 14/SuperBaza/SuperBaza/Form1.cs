using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBaza
{
    public partial class Form1 : Form
    {
        Dosje infa = new Dosje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresher();
        }
        private void Refresher()
        {
            infa = new Dosje();
            TelikIzAeroporta.DataSource = infa.DaiInfu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infa.Vypolnyaj("insert into Bratki(Klikuha) values('" +textBox1.Text +"')");
        }
    }
}

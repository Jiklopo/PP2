using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHITalco10k
{
    public partial class SverhRazum
    {
        public bool Drob;
        public double A, B;
        public string text;

        public ChtoTvoritsya Seychas;
        public ChtoBudemDelat Pozzhe;

        public enum ChtoTvoritsya
        {
            Nichego,
            A,
            B,
            Znak,
            Sdoh,
            Poshitali,
        }

        public enum ChtoBudemDelat
        {
            Plus,
            Minus,
            Delit,
            Umnoj
        }

        public SverhRazum()
        {
            Drob = false;
            Seychas = ChtoTvoritsya.Nichego;
        }

        public void Uznak(string znak)
        {
            switch (znak)
            {
                case "+":
                    Pozzhe = ChtoBudemDelat.Plus;
                    break;
                case "-":
                    Pozzhe = ChtoBudemDelat.Minus;
                    break;
                case ":":
                    Pozzhe = ChtoBudemDelat.Delit;
                    break;
                case "x":
                    Pozzhe = ChtoBudemDelat.Umnoj;
                    break;
                default:
                    break;
            }
        }
    }
}

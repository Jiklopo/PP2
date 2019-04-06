using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHITalco10k
{
    public class SverhRazum
    {
        public ChtoTvoritsya Seychas;
        public ChtoBudemDelat Pozzhe;
        public double A, B;
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
            Seychas = ChtoTvoritsya.Nichego;
        }

        public string Shitalco()
        {
            switch (Pozzhe)
            {
                case ChtoBudemDelat.Plus:
                    return (A + B).ToString();
                case ChtoBudemDelat.Minus:
                    return (A - B).ToString();
                case ChtoBudemDelat.Delit:
                    return (A / B).ToString();
                case ChtoBudemDelat.Umnoj:
                    return (A * B).ToString();
            }
            return "0";
        }
        public void Uznak(string znak)
        {
            switch (znak)
            {
                case "+":
                    Pozzhe = SverhRazum.ChtoBudemDelat.Plus;
                    break;
                case "-":
                    Pozzhe = SverhRazum.ChtoBudemDelat.Minus;
                    break;
                case ":":
                    Pozzhe = SverhRazum.ChtoBudemDelat.Delit;
                    break;
                case "x":
                    Pozzhe = SverhRazum.ChtoBudemDelat.Umnoj;
                    break;
                default:
                    break;
            }
        }
    }
}

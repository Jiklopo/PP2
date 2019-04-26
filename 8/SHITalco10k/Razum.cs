using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHITalco10k
{
    public partial class SverhRazum
    {
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

        public string Ciferka(string cifra, string telik)
        {

            if (Seychas == ChtoTvoritsya.Nichego || Seychas == ChtoTvoritsya.Poshitali || Seychas == ChtoTvoritsya.Sdoh)
            {
                Seychas = ChtoTvoritsya.A;
                if (!Drob)
                    return "" + cifra;
            }
            else if (Seychas == ChtoTvoritsya.Znak)
            {
                Seychas = ChtoTvoritsya.B;
                return "" + cifra;
            }
            return telik + cifra;
        }

        public string ZnakZnachit(string znak, string telik)
        {
            if (Seychas == ChtoTvoritsya.A || Seychas == ChtoTvoritsya.Poshitali)
            {
                Uznak(znak);
                A = double.Parse(telik);
                Drob = false;
                Seychas = ChtoTvoritsya.Znak;
                return "";
            }
            else if (Seychas == ChtoTvoritsya.B)
            {
                Drob = false;
                B = double.Parse(telik);
                string s = Shitalco();
                Uznak(znak);
                A = B;
                Seychas = ChtoTvoritsya.Znak;
                return s;
            }
            else if (Seychas == ChtoTvoritsya.Znak)
            {
                Uznak(znak);
            }
            return telik;
        }


        public string Uravnyat(string telik)
        {
            if (Seychas == ChtoTvoritsya.B)
            {
                B = double.Parse(telik);
                Seychas = ChtoTvoritsya.Poshitali;
                return Shitalco();
            }
            else if (Seychas == ChtoTvoritsya.Poshitali)
            {
                A = double.Parse(telik);
                return Shitalco();
            }
            return telik;
        }

        public string SlozhnoeChislo(string telik)
        {
            if (!Drob)
            {
                Drob = true;
                if (Seychas == ChtoTvoritsya.Nichego)
                {
                    return "0,";
                }
                else if (Seychas == ChtoTvoritsya.Znak)
                {
                    Seychas = ChtoTvoritsya.B;
                    return "0,";
                }
                else
                    return telik + ",";
            }
            return telik;
        }
    }
}

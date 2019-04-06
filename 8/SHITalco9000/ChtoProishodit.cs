using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHITalco9000
{
    public class ChtoProishodit
    {
        public enum ChtoDelaem
        {
            Nichego,
            Slomali,
            Vvodim_A,
            ChtoDelaem_S_A,
            Vvodim_B,
            Poshitali
        }
        public ChtoDelaem chtodelaem;
        public ChtoProishodit()
        {
            chtodelaem = ChtoDelaem.Nichego;
        }
    }
}

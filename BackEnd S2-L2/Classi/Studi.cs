using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L2.Classi
{
    public class Studi
    {
        public Studi(string qualifica, string istituto, string tipo, DateTime dal, DateTime al)
        {
            Qualifica = qualifica;
            Istituto = istituto;
            Tipo = tipo;
            Dal = dal;
            Al = al;
        }


        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
    }
}

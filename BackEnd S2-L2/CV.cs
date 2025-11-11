using BackEnd_S2_L2.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L2
{

    public class CV
    {
        //costruttore
        public CV()
        {
            StudiEffettuati = new List<Studi>();
            Impieghi = new List<Impiego>();

        }



        public InformazioniPersonali InfoPersonali { get; set; } = new InformazioniPersonali();

        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }





    }
}

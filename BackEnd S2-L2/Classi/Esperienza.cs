using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L2.Classi
{
    public class Esperienza
    {
        public Esperienza(string azienda, string jobtitle, DateTime dal, DateTime al, string descrizione, string compiti)
        {

            Azienda = azienda;
            JobTitle = jobtitle;
            Dal = dal;
            Al = al;
            Descrizione = descrizione;
            Compiti = compiti;
        }

        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }

        public static implicit operator Esperienza(string v)
        {
            throw new NotImplementedException();
        }
    }
}

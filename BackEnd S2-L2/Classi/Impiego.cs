using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S2_L2.Classi
{
    public class Impiego
    {
        public Impiego(string esperienza)
        {
            Esperienza = esperienza;
        }

        public Esperienza Esperienza { get; set; }
    }
}

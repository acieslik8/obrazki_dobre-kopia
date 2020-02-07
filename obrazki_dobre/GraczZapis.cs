using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazki_dobre
{
    public class GraczZapis
    {
        public List<Karta> piki1 = new List<Karta>();
        public List<Karta> kiery1 = new List<Karta>();
        public List<Karta> kara1 = new List<Karta>();
        public List<Karta> trefle1 = new List<Karta>();

        public GraczZapis() { }

        public GraczZapis(Gracz g)
        {
            foreach (var i in g.piki)
            {
                piki1.Add(i);
            }
            foreach (var i in g.kiery)
            {
                kiery1.Add(i);
            }
            foreach (var i in g.kara)
            {
                kara1.Add(i);
            }
            foreach (var i in g.trefle)
            {
                trefle1.Add(i);
            }
        }


    }
}

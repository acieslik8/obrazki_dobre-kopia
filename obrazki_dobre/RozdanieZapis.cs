using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazki_dobre
{
    public class RozdanieZapis
    {


        public GraczeZapis gracze;
        public TaliaZapis talia;
        public int numer;
        public int dealer;
        public int zalozenia;

        public RozdanieZapis(Rozdanie r)
        {
            gracze = new GraczeZapis(r.gracze);
            talia = new TaliaZapis(r.talia);
            numer = r.numer;
            zalozenia = (((numer) - 1) / 4 + numer % 4) % 4;
            dealer = numer % 4;
        }
        public RozdanieZapis() { }
    }
}

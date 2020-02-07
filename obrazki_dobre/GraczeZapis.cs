using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazki_dobre
{
    public class GraczeZapis
    {

        public GraczZapis N;
        public GraczZapis S;
        public GraczZapis E;
        public GraczZapis W;

        public GraczeZapis(Gracze g)
        {
            N = new GraczZapis(g.N);
            S = new GraczZapis(g.S);
            E = new GraczZapis(g.E);
            W = new GraczZapis(g.W);
        }
        public GraczeZapis() { }
    }
}

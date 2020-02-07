using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazki_dobre
{
    [Serializable]
    public class Gracze
    {
        public Gracz N;
        public Gracz S;
        public Gracz E;
        public Gracz W;

        public Gracze()
        {
            N = new Gracz("N");
            S = new Gracz("S");
            E = new Gracz("E");
            W = new Gracz("W");
        }
        public Gracze(GraczeZapis g)
        {
            N = new Gracz(g.N);
            S = new Gracz(g.S);
            E = new Gracz(g.E);
            W = new Gracz(g.W);

        }
        /// <summary>
        /// Funkcja podaje wszystkie rozmieszczone karty
        /// </summary>
        /// <returns>string karty w formie BPN</returns>
        public string PodajRozklad()
        {
            string karty = "";
            karty = karty + N.ToString() + " ";
            karty = karty + E.ToString() + " ";
            karty = karty + S.ToString() + " ";
            karty = karty + W.ToString();
            return karty;
        }
    }
}

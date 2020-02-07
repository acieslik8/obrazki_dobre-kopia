using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrazki_dobre
{
    public class TaliaZapis
    {
        public List<Karta> kartyWTalii = new List<Karta>();
        public string wartosci = "23456789TJQKA";
        public string kolory = "CDHS";

        public TaliaZapis(Talia t)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {                    
                    kartyWTalii.Add(t.kartyWTalii[j, i]);
                }
            }
        }
        public TaliaZapis() { }

    }
}

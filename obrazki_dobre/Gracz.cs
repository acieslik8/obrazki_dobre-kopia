using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obrazki_dobre
{
    [Serializable]
    public class Gracz
    {
        public string strona;
        public int liczbaKart;
        public Stack<Karta> reka = new Stack<Karta>();
        public LinkedList<Karta> piki = new LinkedList<Karta>();
        public LinkedList<Karta> kiery = new LinkedList<Karta>();
        public LinkedList<Karta> kara = new LinkedList<Karta>();
        public LinkedList<Karta> trefle = new LinkedList<Karta>();
        /*public List<Karta> piki1 = new List<Karta>();
        public List<Karta> kiery1 = new List<Karta>();
        public List<Karta> kara1 = new List<Karta>();
        public List<Karta> trefle1 = new List<Karta>();*/

        public Gracz(string stronaKon) { strona = stronaKon; liczbaKart = 0; }
        public Gracz (GraczZapis g)
        {
            foreach (var i in g.piki1) { piki.AddLast(i); }
            foreach (var i in g.kiery1) { kiery.AddLast(i); }
            foreach (var i in g.kara1) { kara.AddLast(i); }
            foreach (var i in g.trefle1) { trefle.AddLast(i); }
        }
        public Gracz() { }

        public void Wypisz()
        {
            foreach (var karta in reka)
            {
                Console.Write(karta.Wysokosc + "" + karta.Kolor + "  ");
            }
            Console.WriteLine();
        }
        public void UsunKarte(char w, char k, Talia talia1)
        {
            talia1.UwolnijKarte(new Karta(w, k));
            foreach (var karta in piki)
            {
                if (karta.Wysokosc == w && karta.Kolor == k) { piki.Remove(karta); break; }
            }
            foreach (var karta in kiery)
            {
                if (karta.Wysokosc == w && karta.Kolor == k) { kiery.Remove(karta); break; }
            }
            foreach (var karta in kara)
            {
                if (karta.Wysokosc == w && karta.Kolor == k) { kara.Remove(karta); break; }
            }
            foreach (var karta in trefle)
            {
                if (karta.Wysokosc == w && karta.Kolor == k) { trefle.Remove(karta); break; }
            }
            liczbaKart = piki.Count() + kiery.Count() + kara.Count() + trefle.Count;
            talia1.UwolnijKarte(new Karta(w, k));
        }
        public void wyczysc()
        {
            piki.Clear();
            kiery.Clear();
            kara.Clear();
            trefle.Clear();
        }
/*        public char ZnajdzBlotke(char w, char k, Talia talia)
        {
            string wolne = "";
            if (k == 'S')
            {
                for(int i = 0; i < 8; i++)
                {
                    if(talia.kartyWTalii[i,3].Status == 0)
                    {
                        wolne += talia.kartyWTalii[i,3].Wysokosc;
                    }
                }  
            }
            if (k == 'H')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (talia.kartyWTalii[i, 2].Status == 0)
                    {
                        wolne += talia.kartyWTalii[i, 2].Wysokosc;
                    }
                }
            }
            if (k == 'D')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (talia.kartyWTalii[i, 1].Status == 0)
                    {
                        wolne += talia.kartyWTalii[i, 1].Wysokosc;
                    }
                }
            }
            if (k == 'C')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (talia.kartyWTalii[i, 0].Status == 0)
                    {
                        wolne += talia.kartyWTalii[i, 0].Wysokosc;
                    }
                }
            }
            var rand = new Random();
            if(wolne.Length != 0)
            {
                int r = rand.Next(0, wolne.Length - 1);
                return wolne[r];
            }
            else { return 'x'; }
        }*/
        public void DodajKarte1(char w, char k, Talia talia1)
        {
            //MessageBox.Show(Convert.ToString(w));
            //if (w == 'X') { w = ZnajdzBlotke(w, k, talia1); }
            //if( w == 'x') { break; }
            talia1.ZajmijKarte(new Karta(w, k));
            if (k == 'S')
             {
                 if (piki.Count() == 0) { piki.AddFirst(new Karta(w, k)); }
                 else
                 {
                     foreach (var karta in piki)
                     {
                         if (talia1.wartosci.IndexOf(karta.Wysokosc) < talia1.wartosci.IndexOf(w))
                         {
                             piki.AddBefore(piki.Find(karta), new Karta(w, k));
                             break;
                         }
                         if (karta == piki.Last()) { piki.AddAfter(piki.Find(karta), new Karta(w, k)); break; }
                     }
                 }
             }
             if (k == 'H')
             {
                 if (kiery.Count() == 0) { kiery.AddFirst(new Karta(w, k)); }
                 else
                 {
                     foreach (var karta in kiery)
                     {
                         if (talia1.wartosci.IndexOf(karta.Wysokosc) < talia1.wartosci.IndexOf(w))
                         {
                         kiery.AddBefore(kiery.Find(karta), new Karta(w, k));
                         break;
                         }
                         if (karta == kiery.Last()) { kiery.AddAfter(kiery.Find(karta), new Karta(w, k)); break; }
                     }
                 }
             }
             if (k == 'D')
             {
                 if (kara.Count() == 0) { kara.AddFirst(new Karta(w, k)); }
                 else
                 {
                     foreach (var karta in kara)
                     {
                         if ((talia1.wartosci.IndexOf(karta.Wysokosc) < talia1.wartosci.IndexOf(w)))
                         {
                            kara.AddBefore(kara.Find(karta), new Karta(w, k));
                            break;
                         }
                         if (karta == kara.Last()) { kara.AddAfter(kara.Find(karta), new Karta(w, k)); break; }
                     }
                 }
             }
             if (k == 'C')
             {
                 if (trefle.Count() == 0) { trefle.AddFirst(new Karta(w, k)); }
                 else
                 {
                     foreach (var karta in trefle)
                     {
                        if (talia1.wartosci.IndexOf(karta.Wysokosc) < talia1.wartosci.IndexOf(w))
                        {
                            trefle.AddBefore(trefle.Find(karta), new Karta(w, k));
                            break;
                        }
                            if (karta == trefle.Last()) { trefle.AddAfter(trefle.Find(karta), new Karta(w, k)); break; }
                     }
                 }
             }
            liczbaKart = piki.Count() + kiery.Count() + kara.Count() + trefle.Count;
        }
        public override string ToString()
        {
            string a = "";
            foreach (var karta in piki) { a = a + karta.ToString(); }
            a = a + ".";
            foreach (var karta in kiery) { a = a + karta.ToString(); }
            a = a + ".";
            foreach (var karta in kara) { a = a + karta.ToString(); }
            a = a + ".";
            foreach (var karta in trefle) { a = a + karta.ToString(); }
            return a;
        }


        /*public void Zamien1()
        {
            piki1.Clear();
            kiery1.Clear();
            kara1.Clear();
            trefle1.Clear();
            foreach (var i in piki)
            {
                piki1.Add(i);
            }
            foreach (var i in kiery)
            {
                kiery1.Add(i);
            }
            foreach (var i in kara)
            {
                kara1.Add(i);
            }
            foreach (var i in trefle)
            {
                trefle1.Add(i);
            }
        }
        public void Zamien2()
        {
            piki.Clear();
            kiery.Clear();
            kara.Clear();
            trefle.Clear();
            foreach (var i in piki1)
            {
                piki.AddLast(i);
            }
            foreach (var i in kiery1)
            {
                kiery.AddLast(i);
            }
            foreach (var i in kara1)
            {
                kara.AddLast(i);
            }
            foreach (var i in trefle1)
            {
                trefle.AddLast(i);
            }
        }*/
    }
}

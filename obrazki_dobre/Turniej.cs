using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace obrazki_dobre
{
    [Serializable]
    /// <summary>
    ///  Klasa turniej
    /// </summary>
    public class Turniej : IZapisywalna
    {
        public LinkedList<Rozdanie> Rozdania;

        /// <summary>
        ///  Tworzenie nowego obiektu Turniej
        /// </summary>
        public Turniej()
        {
            Rozdania = new LinkedList<Rozdanie>();
        }
        public Turniej(TurniejZapis t)
        {
            Rozdania = new LinkedList<Rozdanie>();
            Rozdanie r;
            foreach(var i in t.Rozdania)
            {
                r = new Rozdanie(i);
                Rozdania.AddLast(r);
            }
        }

        /*public void Zamien1()
        {
            Rozdania1.Clear();

            foreach (var i in Rozdania)
            {
                i.gracze.N.Zamien1();
                i.gracze.S.Zamien1();
                i.gracze.E.Zamien1();
                i.gracze.W.Zamien1();
                Rozdania1.Add(i);
            }
        }
        public void Zamien2()
        {
            Rozdania.Clear();
            foreach (var i in Rozdania1)
            {
                i.gracze.N.Zamien2();
                i.gracze.S.Zamien2();
                i.gracze.E.Zamien2();
                i.gracze.W.Zamien2();
                Rozdania.AddLast(i);
            }
        }*/

        /// <summary>
        ///  Funkcja sortuje kolejność rozdań w turnieju
        /// </summary>
        public void Sortuj()
        {
            Rozdanie ostatnie = Rozdania.Last();
            foreach(var rozdanie in Rozdania)
            {
                if(rozdanie.numer == ostatnie.numer)
                {
                    Rozdania.AddAfter(Rozdania.Find(rozdanie), ostatnie);
                    Rozdania.RemoveLast();
                    break;
                }
            }
            Rozdanie poprzednie = Rozdania.First();
            foreach(var rozdanie in Rozdania)
            {
                if(rozdanie != Rozdania.First())
                {
                    if(rozdanie.numer == poprzednie.numer)
                    {
                        Rozdania.Remove(Rozdania.Find(rozdanie));
                        break;
                    }
                    poprzednie = rozdanie;
                }
            }
        }

    }
}

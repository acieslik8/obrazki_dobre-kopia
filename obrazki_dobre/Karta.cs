using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace obrazki_dobre
{
    [Serializable]
    public class Karta
    {
        public char Wysokosc;
        public char Kolor;
        public int Status;
        //public LinkedList<int> lista;
        //public List<int> lista;


        public Karta() { }

        public Karta(char w, char k)
        {
            Wysokosc = w;
            Kolor = k;
            Status = 0;
            /*lista = new LinkedList<int>();
            lista.AddFirst(5);*/
            /*lista = new List<int>();
            lista.Add(5);*/
        }

        public override string ToString()
        {
            return Convert.ToString(Wysokosc);// +Convert.ToString(kolor);
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



        /*public void ZapiszBIN(string nazwa, Karta t)
        {
            var serializer = new XmlSerializer(typeof(Karta));
            var sw = new StreamWriter(nazwa);
            serializer.Serialize(sw, t);
            sw.Close();
        }
        public Object OdczytajBIN(string nazwa)
        {
            Karta kartaOdczyt;
            var fs = new FileStream(nazwa, FileMode.Open);
            var bf = new XmlSerializer(typeof(Karta));
            kartaOdczyt = (Karta)bf.Deserialize(fs);
            fs.Close();
            return kartaOdczyt;
        }*/
    }
}

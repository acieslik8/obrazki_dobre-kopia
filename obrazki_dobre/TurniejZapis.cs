using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace obrazki_dobre
{
    public class TurniejZapis
    {
        public List<RozdanieZapis> Rozdania;

        public TurniejZapis(Turniej t)
        {
            Rozdania = new List<RozdanieZapis>();
            RozdanieZapis r;
            foreach (var i in t.Rozdania)
            {
                r = new RozdanieZapis(i);
                Rozdania.Add(r);
            }
        }
        public TurniejZapis()
        {
            Rozdania = new List<RozdanieZapis>();
        }


        public void ZapiszBIN(string nazwa, TurniejZapis t)
        {
            var serializer = new XmlSerializer(typeof(TurniejZapis));
            var sw = new StreamWriter(nazwa);
            serializer.Serialize(sw, t);
            sw.Close();

        }
        public Object OdczytajBIN(string nazwa)
        {
            TurniejZapis turniejOdczyt;
            var fs = new FileStream(nazwa, FileMode.Open);
            var bf = new XmlSerializer(typeof(TurniejZapis));
            turniejOdczyt = (TurniejZapis)bf.Deserialize(fs);
            fs.Close();
            return turniejOdczyt;

        }
    }
}

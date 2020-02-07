using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obrazki_dobre
{
    [Serializable]
    public class Talia
    {
        public Karta[,] kartyWTalii = new Karta[13, 4];
        public string wartosci = "23456789TJQKA";
        public string kolory = "CDHS";

        public Talia()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    kartyWTalii[j, i] = new Karta(wartosci[j], kolory[i]);
                }
            }
        }
        public Talia(TaliaZapis t)
        {
            int i = 0, j;
            foreach(var k in t.kartyWTalii)
            {
                kartyWTalii[i % 13, (i - (i % 13))/13] = k;
                i++;
            }
        }
        public void ZajmijKarte(Karta zajeta)
        {
            foreach (var karta in kartyWTalii)
            {
                if ((karta.Kolor == zajeta.Kolor) && (karta.Wysokosc == zajeta.Wysokosc)) { karta.Status = 1; }
            }
        }
        public void UwolnijKarte(Karta zajeta)
        {
            foreach (var karta in kartyWTalii)
            {
                if ((karta.Kolor == zajeta.Kolor) && (karta.Wysokosc == zajeta.Wysokosc)) { karta.Status = 0; }
            }
        }
        public string CzyZajetaKarta(Karta zajeta)
        {
            string a = "brak karty ";
            foreach (var karta in kartyWTalii)
            {
                if ((karta.Kolor == zajeta.Kolor) && (karta.Wysokosc == zajeta.Wysokosc))
                {
                    if (karta.Status == 0) { a = "ok"; }
                    else { a = "Karta wykorzystana"; MessageBox.Show(a); }
                }
            }
            if (zajeta.Wysokosc == 'X')
            {
                /*int blotka = losujBlotke(zajeta.Kolor);
                ZajmijKarte(new Karta(Convert.ToChar(blotka), zajeta.Kolor));*/
                a = "ok";
            }
            if (a == "brak karty ") { MessageBox.Show(a + zajeta.ToString()); }
            return a;
        }
        int losujBlotke(char kolor)
        {
            int s = 0;
            var rand = new Random();
            int los;
            los = rand.Next(2, 9);
            /*for (int i = 2; i < 10; i++)
            {
                if (CzyZajetaKarta(new Karta(Convert.ToChar(i), kolor)) == "ok")
                {
                    s = 1;
                }
            }
            if (s == 1)
            {
                
                los = rand.Next(2, 9);
                ZajmijKarte(new Karta(Convert.ToChar(los), zajeta.Kolor));
            }
            else { MessageBox.Show("Wszystkie blotki wykorzystane"); }*/
            return los;
        }
    }
}

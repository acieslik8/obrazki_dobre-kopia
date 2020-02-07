using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obrazki_dobre
{
    [Serializable]
    /// <summary>
    /// Klasa zawierajaca czterechgraczy, o okreslonym numerze, zalozeniach, dealerze
    /// </summary>
    public class Rozdanie
    {
        public Gracze gracze;
        public Talia talia;
        public int numer;
        public int dealer;
        public int zalozenia;
        public Stack<string> ostatnie = new Stack<string>();

        /// <summary>
        /// Tworzy nowe rozdanie o podanym numerze
        /// </summary>
        public Rozdanie(int numerKon)
        {
            gracze = new Gracze();
            talia = new Talia();
            numer = numerKon;
            zalozenia = (((numer) - 1) / 4 + numer % 4) % 4;
            dealer = numer % 4;
            ostatnie = new Stack<string>();

        }
        /// <summary>
        /// Tworzy nowe rozdanie po odczycie pliku XML
        /// </summary>
        public Rozdanie(RozdanieZapis r)
        {
            gracze = new Gracze(r.gracze);
            talia = new Talia(r.talia);
            numer = r.numer;
            zalozenia = (((numer) - 1) / 4 + numer % 4) % 4;
            dealer = numer % 4;
        }
        public Rozdanie() { }
        /// <summary>
        ///  Funkcja dodaje nowa karte dla odpowiedniego gracza
        /// </summary>
        /// <param name="gracz">Gracz, ktoremu zostanie dodana karta</param>
        /// <param name="kolor">Kolor dodawanej karty</param>
        /// <param name="wysokosc">Wysokosc dodawanej karty</param>
        public void dodajKarte(char gracz, char wysokosc, char kolor)
        {           
            if (talia.CzyZajetaKarta(new Karta(wysokosc, kolor)) == "ok")
            {
                if (gracz == 'N')
                {
                    gracze.N.DodajKarte1(wysokosc, kolor, talia);
                }
                if (gracz == 'S')
                {
                    gracze.S.DodajKarte1(wysokosc, kolor, talia);
                }
                if (gracz == 'E')
                {
                    gracze.E.DodajKarte1(wysokosc, kolor, talia);
                }
                if (gracz == 'W')
                {
                    gracze.W.DodajKarte1(wysokosc, kolor, talia);
                }
            }
        }

        /// <summary>
        /// Funkcja podaje, ktory gracz jest dealerem w tym rozdaniu
        /// </summary>
        /// <returns>Oznaczenie gracza, ktory jest dealerem (N/S/E/W)</returns>
        public string Podajdealera()
        {
            switch (dealer)
            {
                case 1: return "N";
                case 2: return "E";
                case 3: return "S";
                default: return "W";
            }            
        }
        /// <summary>
        /// Funkcja podaje zalozenia obowiazujace w tym rozdaniu
        /// </summary>
        /// <returns>Oznaczenie zalozen (NS/EW/All/None)</returns>
        public string PodajZalozenia()
        {
            switch (zalozenia)
            {
                case 1: return "None";
                case 2: return "NS";
                case 3: return "EW";
                default: return "All";
            }
        }
    }
}

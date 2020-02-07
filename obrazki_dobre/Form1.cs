using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace obrazki_dobre
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListBox listBox2 = new ListBox();
            listBox2.Location = new System.Drawing.Point(20, 20);
            listBox2.Size = new System.Drawing.Size(200, 200);
            listBox2.BackColor = Color.Blue;
            turniej.Rozdania.AddFirst(rozdanie);
            
        }
        
        public int numer = 1;
        public int zalozenia = 1;
        public int dealer = 1;
        public Turniej turniej = new Turniej();
        public Rozdanie rozdanie = new Rozdanie(1);

        private void button1_Click_1(object sender, EventArgs e)
        {
            char w;
            if (pikiN.Text.Length > 0 && rozdanie.gracze.N.liczbaKart < 13)
            {
                char[] dodaj = popraw(pikiN.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.N.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'S'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('N', w, 'S');
                    rozdanie.ostatnie.Push(w + "S");
                }
            }
            if (kieryN.Text.Length > 0 && rozdanie.gracze.N.liczbaKart < 13)
            {
                char[] dodaj = popraw(kieryN.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.N.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'H'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('N', w, 'H');
                    rozdanie.ostatnie.Push(w + "H");
                }
            }
            if (karaN.Text.Length > 0 && rozdanie.gracze.N.liczbaKart < 13)
            {
                char[] dodaj = popraw(karaN.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.N.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'D'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('N', w, 'D');
                    rozdanie.ostatnie.Push(w + "D");
                }
            }
            if (trefleN.Text.Length > 0 && rozdanie.gracze.N.liczbaKart < 13)
            {
                char[] dodaj = popraw(trefleN.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.N.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'C'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('N', w, 'C');
                    rozdanie.ostatnie.Push(w + "C");
                }
            }

            if (pikiS.Text.Length > 0 && rozdanie.gracze.S.liczbaKart < 13)
            {
                char[] dodaj = popraw(pikiS.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.S.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'S'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('S', w, 'S');
                    rozdanie.ostatnie.Push(w + "S");
                }
            }
            if (kieryS.Text.Length > 0 && rozdanie.gracze.S.liczbaKart < 13)
            {
                char[] dodaj = popraw(kieryS.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.S.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'H'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('S', w, 'H');
                    rozdanie.ostatnie.Push(w + "H");
                }
            }
            if (karaS.Text.Length > 0 && rozdanie.gracze.S.liczbaKart < 13)
            {
                char[] dodaj = popraw(karaS.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.S.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'D'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('S', w, 'D');
                    rozdanie.ostatnie.Push(w + "D");
                }
            }
            if (trefleS.Text.Length > 0 && rozdanie.gracze.S.liczbaKart < 13)
            {
                char[] dodaj = popraw(trefleS.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.S.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'C'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('S', w, 'C');
                    rozdanie.ostatnie.Push(w + "C");
                }
            }

            if (pikiW.Text.Length > 0 && rozdanie.gracze.W.liczbaKart < 13)
            {
                char[] dodaj = popraw(pikiW.Text.ToString());
                foreach(var litera in dodaj)
                {
                    if (rozdanie.gracze.W.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'S'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('W', w, 'S');
                    rozdanie.ostatnie.Push(w + "S");
                }
            }
            if (kieryW.Text.Length > 0 && rozdanie.gracze.W.liczbaKart < 13)
            {
                char[] dodaj = popraw(kieryW.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.W.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'H'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('W', w, 'H');
                    rozdanie.ostatnie.Push(w + "H");
                }
            }
            if (karaW.Text.Length > 0 && rozdanie.gracze.W.liczbaKart < 13)
            {
                char[] dodaj = popraw(karaW.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.W.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'D'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('W', w, 'D');
                    rozdanie.ostatnie.Push(w + "D");
                }
            }
            if (trefleW.Text.Length > 0 && rozdanie.gracze.W.liczbaKart < 13)
            {
                char[] dodaj = popraw(trefleW.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.W.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'C'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('W', w, 'C');
                    rozdanie.ostatnie.Push(w + "C");
                }
            }

            if (pikiE.Text.Length > 0 && rozdanie.gracze.E.liczbaKart < 13)
            {
                char[] dodaj = popraw(pikiE.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.E.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'S'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('E', w, 'S');
                    rozdanie.ostatnie.Push(w + "S");
                }
            }
            if (kieryE.Text.Length > 0 && rozdanie.gracze.E.liczbaKart < 13)
            {
                char[] dodaj = popraw(kieryE.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.E.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'H'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('E', w, 'H');
                    rozdanie.ostatnie.Push(w + "H");
                }
            }
            if (karaE.Text.Length > 0 && rozdanie.gracze.E.liczbaKart < 13)
            {
                char[] dodaj = popraw(karaE.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.E.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'D'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('E', w, 'D');
                    rozdanie.ostatnie.Push(w + "D");
                }
            }
            if (trefleE.Text.Length > 0 && rozdanie.gracze.E.liczbaKart < 13)
            {
                char[] dodaj = popraw(trefleE.Text.ToString());
                foreach (var litera in dodaj)
                {
                    if (rozdanie.gracze.E.liczbaKart >= 13) { MessageBox.Show("Podano za duzo kart"); break; }
                    if (litera == 'X') { w = ZnajdzBlotke(litera, 'C'); }
                    else { w = litera; }
                    rozdanie.dodajKarte('E', w, 'C');
                    rozdanie.ostatnie.Push(w + "C");
                }
            }
            odswiez();
        }

        /// <summary>
        /// Funkcja poprawia podane karty, zwracajac je w formie czytanej przez funkcje rozdanie.DodajKarte()
        /// </summary>
        /// <returns>Symbole kart do wczytania jako string</returns>
        public char[] popraw(string dozmiany)
        {
            dozmiany = dozmiany.ToUpper();
            char[] zmienione = new char[dozmiany.Length];
            int j = 0;
            for (int i = 0; i < dozmiany.Length; i++)
            {
                zmienione[j] = dozmiany[i];
                if (zmienione[j] == '1' && dozmiany[i+1] == '0') { zmienione[i] = 'T'; i++; }
                if (zmienione[j] == 'W') { zmienione[j] = 'J'; }
                if (zmienione[j] == 'D') { zmienione[j] = 'Q'; }
                j++;
            }
            if(zmienione[zmienione.Length-1] != 0) { return poprawblotki(zmienione);}
            else
            {
                char[] zmienione1 = new char[dozmiany.Length-1];
                for (int i = 0; i< zmienione1.Length; i++) { zmienione1[i] = zmienione[i]; }
                return poprawblotki(zmienione1);
            }            
        }

        /// <summary>
        /// Uzupelnienie funkcji popraw
        /// </summary>
        public char[] poprawblotki(char[] dozmiany)
        {
            for (int i = 0; i < dozmiany.Length; i++)
            {
                if (dozmiany[i] == 'X')
                {
                    for(int j = i; j < dozmiany.Length - 1; j++)
                    {
                        dozmiany[j] = dozmiany[j + 1];
                    }
                    dozmiany[dozmiany.Length - 1] = 'X';
                }
            }
            string a = "";
            for(int i = 0; i < dozmiany.Length; i++)
            {
                a = a + dozmiany[i];
            }
            //MessageBox.Show(a);
            return dozmiany;
        }

        /// <summary>
        /// Funkcja znajduje wszystkie wolne blotki w podanym kolorze, a nastepnie zwraca losowa z nich
        /// </summary>
        /// <param name="k">Kolor w ktorym ma zostac zwrocona blotka</param>
        /// <returns>Wylosowana blotka w podanym kolorze, jesli brak wolnej blotki, zwraca "x"</returns>
        public char ZnajdzBlotke(char w, char k)
        {
            string wolne = "";
            if (k == 'S')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (rozdanie.talia.kartyWTalii[i, 3].Status == 0)
                    {
                        wolne += rozdanie.talia.kartyWTalii[i, 3].Wysokosc;
                    }
                }
            }
            if (k == 'H')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (rozdanie.talia.kartyWTalii[i, 2].Status == 0)
                    {
                        wolne += rozdanie.talia.kartyWTalii[i, 2].Wysokosc;
                    }
                }
            }
            if (k == 'D')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (rozdanie.talia.kartyWTalii[i, 1].Status == 0)
                    {
                        wolne += rozdanie.talia.kartyWTalii[i, 1].Wysokosc;
                    }
                }
            }
            if (k == 'C')
            {
                for (int i = 0; i < 8; i++)
                {
                    if (rozdanie.talia.kartyWTalii[i, 0].Status == 0)
                    {
                        wolne += rozdanie.talia.kartyWTalii[i, 0].Wysokosc;
                    }
                }
            }
            var rand = new Random();
            if (wolne.Length != 0)
            {
                int r = rand.Next(0, wolne.Length - 1);
                return wolne[r];
            }
            else { return 'x'; }
        }
        /// <summary>
        /// Odswieza widok
        /// </summary>
        private void odswiez()
        {
            pikiN.Clear();
            pikiNBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.N.piki) { pikiNBox.Items.Add(karta.ToString()); }
            kieryN.Clear();
            kieryNBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.N.kiery) { kieryNBox.Items.Add(karta.ToString()); }
            karaN.Clear();
            karaNBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.N.kara) { karaNBox.Items.Add(karta.ToString()); }
            trefleN.Clear();
            trefleNBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.N.trefle) { trefleNBox.Items.Add(karta.ToString()); }

            pikiS.Clear();
            pikiSBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.S.piki) { pikiSBox.Items.Add(karta.ToString()); }
            kieryS.Clear();
            kierySBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.S.kiery) { kierySBox.Items.Add(karta.ToString()); }
            karaS.Clear();
            karaSBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.S.kara) { karaSBox.Items.Add(karta.ToString()); }
            trefleS.Clear();
            trefleSBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.S.trefle) { trefleSBox.Items.Add(karta.ToString()); }

            pikiW.Clear();
            pikiWBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.W.piki) { pikiWBox.Items.Add(karta.ToString()); }
            kieryW.Clear();
            kieryWBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.W.kiery) { kieryWBox.Items.Add(karta.ToString()); }
            karaW.Clear();
            karaWBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.W.kara) { karaWBox.Items.Add(karta.ToString()); }
            trefleW.Clear();
            trefleWBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.W.trefle) { trefleWBox.Items.Add(karta.ToString()); }

            pikiE.Clear();
            pikiEBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.E.piki) { pikiEBox.Items.Add(karta.ToString()); }
            kieryE.Clear();
            kieryEBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.E.kiery) { kieryEBox.Items.Add(karta.ToString()); }
            karaE.Clear();
            karaEBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.E.kara) { karaEBox.Items.Add(karta.ToString()); }
            trefleE.Clear();
            trefleEBox.Items.Clear();
            foreach (var karta in rozdanie.gracze.E.trefle) { trefleEBox.Items.Add(karta.ToString()); }

            for (int i = 0; i < 13; i++) // zmiana niebieskiego pola
            {
                if (rozdanie.talia.kartyWTalii[i, 3].Status == 0) { piki.SetSelected((12 - i), false); }
                else { piki.SetSelected((12 - i), true); }
                if (rozdanie.talia.kartyWTalii[i, 2].Status == 0) { kiery.SetSelected((12 - i), false); }
                else { kiery.SetSelected((12 - i), true); }
                if (rozdanie.talia.kartyWTalii[i, 1].Status == 0) { kara.SetSelected((12 - i), false); }
                else { kara.SetSelected((12 - i), true); }
                if (rozdanie.talia.kartyWTalii[i, 0].Status == 0) { trefle.SetSelected((12 - i), false); }
                else { trefle.SetSelected((12 - i), true); }
            }
        }

        /// <summary>
        /// Znajduje na stosie "ostatnie" ostatnio dodana karte, a nastepnie usuwa ja
        /// </summary>
        private void cofnij_Click(object sender, EventArgs e)
        {
            if (rozdanie.ostatnie.Count() != 0)
            {

                string usun = rozdanie.ostatnie.Pop();
                rozdanie.gracze.N.UsunKarte(usun[0], usun[1], rozdanie.talia);
                rozdanie.gracze.S.UsunKarte(usun[0], usun[1], rozdanie.talia);
                rozdanie.gracze.E.UsunKarte(usun[0], usun[1], rozdanie.talia);
                rozdanie.gracze.W.UsunKarte(usun[0], usun[1], rozdanie.talia);
                odswiez();
            }
            else { MessageBox.Show("Nie można cofnąć"); }
        }
        /// <summary>
        /// Czysci karty wszystkich graczy w otwartym rozdaniu
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            string message = "Czy chcesz wyczyścic wszystko?";
            string caption = "Wyczyść";
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                wyczysnN_Click(sender, e);
                wyczyscS_Click(sender, e);
                wyczyscE_Click(sender, e);
                wyczyscW_Click(sender, e);
            }            
        }

        private void wyczysnN_Click(object sender, EventArgs e)
        {
            foreach (var karta in rozdanie.gracze.N.piki) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.N.kiery) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.N.kara) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.N.trefle) { rozdanie.talia.UwolnijKarte(karta); }
            rozdanie.gracze.N.wyczysc();
            rozdanie.gracze.N.liczbaKart = 0;
            rozdanie.ostatnie.Clear();
            odswiez();
        }

        private void wyczyscS_Click(object sender, EventArgs e)
        {
            foreach (var karta in rozdanie.gracze.S.piki) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.S.kiery) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.S.kara) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.S.trefle) { rozdanie.talia.UwolnijKarte(karta); }
            rozdanie.gracze.S.wyczysc();
            rozdanie.gracze.S.liczbaKart = 0;
            rozdanie.ostatnie.Clear();
            odswiez();
        }

        private void wyczyscE_Click(object sender, EventArgs e)
        {
            foreach (var karta in rozdanie.gracze.E.piki) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.E.kiery) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.E.kara) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.E.trefle) { rozdanie.talia.UwolnijKarte(karta); }
            rozdanie.gracze.E.wyczysc();
            rozdanie.gracze.E.liczbaKart = 0;
            rozdanie.ostatnie.Clear();
            odswiez();
        }

        private void wyczyscW_Click(object sender, EventArgs e)
        {
            foreach (var karta in rozdanie.gracze.W.piki) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.W.kiery) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.W.kara) { rozdanie.talia.UwolnijKarte(karta); }
            foreach (var karta in rozdanie.gracze.W.trefle) { rozdanie.talia.UwolnijKarte(karta); }
            rozdanie.gracze.W.wyczysc();
            rozdanie.gracze.W.liczbaKart = 0;
            rozdanie.ostatnie.Clear();
            odswiez();
        }

        private void losuj_Click(object sender, EventArgs e)
        {
            int los = 1;
            var rand = new Random();
            foreach(var karta in rozdanie.talia.kartyWTalii)
            {
                los = rand.Next(1, 5);
                if(karta.Status == 0)
                {
                    wylosujKarte(karta, los, rand);
                }
            }
            rozdanie.ostatnie.Clear();
            odswiez();
        }
        /// <summary>
        /// Przydziela losowo wszystkie niewykorzystane karty
        /// </summary>
        private void wylosujKarte(Karta karta, int los, Random rand)
        {
            switch (los)
            {
                case 1:
                    if (rozdanie.gracze.N.liczbaKart < 13)
                    {
                        rozdanie.gracze.N.DodajKarte1(karta.Wysokosc, karta.Kolor, rozdanie.talia);
                    }
                    else { los = rand.Next(1, 5); wylosujKarte(karta, los,rand); }
                    break;
                case 2:
                    if (rozdanie.gracze.S.liczbaKart < 13)
                    {
                        rozdanie.gracze.S.DodajKarte1(karta.Wysokosc, karta.Kolor, rozdanie.talia);
                    }
                    else { los = rand.Next(1, 5); wylosujKarte(karta, los, rand); }
                    break;
                case 3:
                    if (rozdanie.gracze.E.liczbaKart < 13)
                    {
                        rozdanie.gracze.E.DodajKarte1(karta.Wysokosc, karta.Kolor, rozdanie.talia);
                    }
                    else { los = rand.Next(1, 5); wylosujKarte(karta, los, rand); }
                    break;
                case 4:
                    if (rozdanie.gracze.W.liczbaKart < 13)
                    {
                        rozdanie.gracze.W.DodajKarte1(karta.Wysokosc, karta.Kolor, rozdanie.talia);
                    }
                    else { los = rand.Next(1, 5); wylosujKarte(karta, los, rand); }
                    break;
            }
        }

        /// <summary>
        /// Tworzy nowe rozdanie o podanym numerze
        /// </summary>
        private void nowe(int nowyNumer)
        {
            numer = nowyNumer;
            //rozdanie = new Rozdanie(new Talia(), new Gracze(), numer, new Stack<string>());
            rozdanie = new Rozdanie(numer);
            zalozenia = (((numer) - 1) / 4 + numer % 4) % 4;
            dealer = numer % 4;
            numer1.Items.Clear();
            numer1.Items.Add(numer);

            turniej.Rozdania.AddLast(rozdanie);
            turniej.Sortuj();
            /*if (turniej.Rozdania.Count() == 0) { turniej.Rozdania.AddFirst(rozdanie); }
            else
            {
                turniej.Rozdania.AddLast(rozdanie);
                turniej.Sortuj();
            } */           

            foreach (var rozdanie1 in turniej.Rozdania)
            {
                if (rozdanie1.numer == nowyNumer)
                {
                    rozdanie = rozdanie1;
                    break;
                }
            }
            odswiez();

            System.Drawing.Font fontDealer = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            System.Drawing.Font font1 = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

            if (dealer == 1)
            {
                zalN.Font = fontDealer;
                zalS.Font = font1;
                zalE.Font = font1;
                zalW.Font = font1;
            }
            if (dealer == 2)
            {
                zalN.Font = font1;
                zalS.Font = font1;
                zalE.Font = fontDealer;
                zalW.Font = font1;
            }
            if (dealer == 3)
            {
                zalN.Font = font1;
                zalS.Font = fontDealer;
                zalE.Font = font1;
                zalW.Font = font1;
            }
            if (dealer == 0)
            {
                zalN.Font = font1;
                zalS.Font = font1;
                zalE.Font = font1;
                zalW.Font = fontDealer;
            }
            if (zalozenia == 1)
            {
                zalN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            if (zalozenia == 2)
            {
                zalN.BackColor = System.Drawing.Color.Red;
                zalS.BackColor = System.Drawing.Color.Red;
                zalE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }
            if (zalozenia == 3)
            {
                zalN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                zalE.BackColor = System.Drawing.Color.Red;
                zalW.BackColor = System.Drawing.Color.Red;
            }
            if (zalozenia == 0)
            {
                zalN.BackColor = System.Drawing.Color.Red;
                zalS.BackColor = System.Drawing.Color.Red;
                zalE.BackColor = System.Drawing.Color.Red;
                zalW.BackColor = System.Drawing.Color.Red;
            }
        }
        /// <summary>
        /// Przechodzi do nowego rozdania wedlug podanego numeru
        /// </summary>
        private void Nowe_Click(object sender, EventArgs e)
        {
            int nowyNumer;
            if (noweNumer.Text.Length > 0) { nowyNumer = Convert.ToInt32(noweNumer.Text.ToString()); noweNumer.Clear(); }
            else { nowyNumer = numer + 1; }
            nowe(nowyNumer);
        }
        private void poprzedni_Click(object sender, EventArgs e)
        {
            int nowyNumer;
            if(numer != 1) { nowyNumer = numer - 1; nowe(nowyNumer); }

        }

        private void nastepny_Click(object sender, EventArgs e)
        {
            int nowyNumer = numer + 1;
            nowe(nowyNumer);
        }

        /// <summary>
        /// Zapisuje turniej do pliku XML
        /// </summary>
        private void ZapiszZmiany_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName != "")
                {
                    TurniejZapis t = new TurniejZapis(turniej);
                    t.ZapiszBIN(dlg.FileName, t);
                }
                else { MessageBox.Show("Nie podano nazwy pliku", "Błąd zapisywania"); }
            }

                                    
        }
        /// <summary>
        /// Wczytuje plik XML i tworzy na jego podstawie nowy turniej
        /// </summary>
        private void WczytajPoprzedni_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    TurniejZapis turniejzapis = new TurniejZapis();
                    turniejzapis = (TurniejZapis)turniejzapis.OdczytajBIN(filePath);
                    turniej = new Turniej(turniejzapis);
                    nowe(numer);
                }
            }

        }
        /// <summary>
        /// Generuje plik PBN, mozliwy do odczytania przez inne programy
        /// </summary>
        private void PbnButton_Click(object sender, EventArgs e)
        {                     
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != "")
            {
                dlg.DefaultExt = "txt";

                if (!System.IO.File.Exists(dlg.FileName))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(dlg.FileName))
                    {
                        file.WriteLine("% PBN 1.0\n% EXPORT\n%");
                        foreach (var rozdanie1 in turniej.Rozdania)
                        {
                            file.WriteLine("[Board " + '"' + rozdanie1.numer + '"' + ']');
                            file.WriteLine("[Dealer " + '"' + rozdanie1.Podajdealera() + '"' + ']');
                            file.WriteLine("[Vulnerable " + '"' + rozdanie1.PodajZalozenia() + '"' + ']');
                            file.WriteLine("[Deal " + '"' + "N:" + rozdanie1.gracze.PodajRozklad() + '"' + "]\n*\n");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Plik o podanej nazwie juz istnieje");
                }
            }

        }

        private void Pomoc_Click(object sender, EventArgs e)
        {
            var pomoc = new Form2();
            pomoc.ShowDialog();
        }
        /// <summary>
        /// Tworzy nowy turniej. Nie zapisuje domyslnie poprzedniego turnieju.
        /// </summary>
        private void NowyPlik_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            string message = "Czy chcesz utworzyć nowy plik? Niezapisane zmiany zostaną utracone.";
            string caption = "Nowy plik";
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                numer = 1;
                zalozenia = 1;
                dealer = 1;
                turniej = new Turniej();
                rozdanie = new Rozdanie(1);
                nowe(1);
            }
        }
    }
}

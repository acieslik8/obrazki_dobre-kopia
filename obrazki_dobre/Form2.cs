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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public System.Drawing.Font font1 = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        public System.Drawing.Font font2 = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

        private void rozmieszczenieKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tresc1.Visible = true;
            tresc2.Visible = false;
            tresc3.Visible = false;
            rozmieszczenieKartToolStripMenuItem.Font = font1;
            noweRozdanieToolStripMenuItem.Font = font2;
            zapisywanieToolStripMenuItem.Font = font2;
        }
        private void noweRozdanieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tresc1.Visible = false;
            tresc2.Visible = true;
            tresc3.Visible = false;
            rozmieszczenieKartToolStripMenuItem.Font = font2;
            noweRozdanieToolStripMenuItem.Font = font1;
            zapisywanieToolStripMenuItem.Font = font2;
        }
        private void zapisywanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tresc1.Visible = false;
            tresc2.Visible = false;
            tresc3.Visible = true;
            rozmieszczenieKartToolStripMenuItem.Font = font2;
            noweRozdanieToolStripMenuItem.Font = font2;
            zapisywanieToolStripMenuItem.Font = font1;
        }
    }
}

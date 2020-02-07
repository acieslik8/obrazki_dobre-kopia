namespace obrazki_dobre
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tresc1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rozmieszczenieKartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweRozdanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisywanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tresc2 = new System.Windows.Forms.Label();
            this.tresc3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witaj w oknie pomocy";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program służący do generowania rozdań brydżowych, oraz zapisywania ich w formacie" +
    " PBN (Portable Bridge Notation).";
            // 
            // tresc1
            // 
            this.tresc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tresc1.Location = new System.Drawing.Point(37, 210);
            this.tresc1.Name = "tresc1";
            this.tresc1.Size = new System.Drawing.Size(848, 283);
            this.tresc1.TabIndex = 5;
            this.tresc1.Text = resources.GetString("tresc1.Text");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "As",
            "Król",
            "Dama",
            "Walet",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "blotka"});
            this.listBox1.Location = new System.Drawing.Point(961, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(76, 300);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "A",
            "K",
            "Q / D",
            "J / W",
            "T / 10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "X"});
            this.listBox2.Location = new System.Drawing.Point(1043, 94);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(70, 300);
            this.listBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(944, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oznaczenia kart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rozmieszczenieKartToolStripMenuItem,
            this.noweRozdanieToolStripMenuItem,
            this.zapisywanieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(42, 140);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(561, 43);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rozmieszczenieKartToolStripMenuItem
            // 
            this.rozmieszczenieKartToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.rozmieszczenieKartToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozmieszczenieKartToolStripMenuItem.Name = "rozmieszczenieKartToolStripMenuItem";
            this.rozmieszczenieKartToolStripMenuItem.Size = new System.Drawing.Size(220, 39);
            this.rozmieszczenieKartToolStripMenuItem.Text = "Rozmieszczenie kart";
            this.rozmieszczenieKartToolStripMenuItem.Click += new System.EventHandler(this.rozmieszczenieKartToolStripMenuItem_Click);
            // 
            // noweRozdanieToolStripMenuItem
            // 
            this.noweRozdanieToolStripMenuItem.Name = "noweRozdanieToolStripMenuItem";
            this.noweRozdanieToolStripMenuItem.Size = new System.Drawing.Size(158, 39);
            this.noweRozdanieToolStripMenuItem.Text = "Nowe rozdanie";
            this.noweRozdanieToolStripMenuItem.Click += new System.EventHandler(this.noweRozdanieToolStripMenuItem_Click);
            // 
            // zapisywanieToolStripMenuItem
            // 
            this.zapisywanieToolStripMenuItem.Name = "zapisywanieToolStripMenuItem";
            this.zapisywanieToolStripMenuItem.Size = new System.Drawing.Size(132, 39);
            this.zapisywanieToolStripMenuItem.Text = "Zapisywanie";
            this.zapisywanieToolStripMenuItem.Click += new System.EventHandler(this.zapisywanieToolStripMenuItem_Click);
            // 
            // tresc2
            // 
            this.tresc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tresc2.Location = new System.Drawing.Point(37, 210);
            this.tresc2.Name = "tresc2";
            this.tresc2.Size = new System.Drawing.Size(848, 283);
            this.tresc2.TabIndex = 13;
            this.tresc2.Text = "Tresc 2";
            this.tresc2.Visible = false;
            // 
            // tresc3
            // 
            this.tresc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tresc3.Location = new System.Drawing.Point(38, 210);
            this.tresc3.Name = "tresc3";
            this.tresc3.Size = new System.Drawing.Size(848, 283);
            this.tresc3.TabIndex = 14;
            this.tresc3.Text = resources.GetString("tresc3.Text");
            this.tresc3.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 645);
            this.Controls.Add(this.tresc3);
            this.Controls.Add(this.tresc2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tresc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Pomoc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tresc1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rozmieszczenieKartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweRozdanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisywanieToolStripMenuItem;
        private System.Windows.Forms.Label tresc2;
        private System.Windows.Forms.Label tresc3;
    }
}
namespace AkademineIS
{
    partial class Pagrindinis
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
            menuStrip1 = new MenuStrip();
            MenuItemST = new ToolStripMenuItem();
            MenuItemNaujasST = new ToolStripMenuItem();
            MenuItemSTsar = new ToolStripMenuItem();
            MenuItemSTATS = new ToolStripMenuItem();
            redaguotiStudToolStripMenuItem = new ToolStripMenuItem();
            MenuItemDalykas = new ToolStripMenuItem();
            pridetiDalykaToolStripMenuItem = new ToolStripMenuItem();
            istrintiDalykaToolStripMenuItem = new ToolStripMenuItem();
            redaguotiDalykaToolStripMenuItem = new ToolStripMenuItem();
            MenuItemIvertinimas = new ToolStripMenuItem();
            tvarkytiIvertinimusToolStripMenuItem = new ToolStripMenuItem();
            MenuItemDestytojas = new ToolStripMenuItem();
            pRIDETIDESTYTOJAToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemST, MenuItemDalykas, MenuItemIvertinimas, MenuItemDestytojas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemST
            // 
            MenuItemST.DropDownItems.AddRange(new ToolStripItem[] { MenuItemNaujasST, MenuItemSTsar, MenuItemSTATS, redaguotiStudToolStripMenuItem });
            MenuItemST.Name = "MenuItemST";
            MenuItemST.Size = new Size(98, 25);
            MenuItemST.Text = "Studentas";
            // 
            // MenuItemNaujasST
            // 
            MenuItemNaujasST.BackColor = Color.MediumAquamarine;
            MenuItemNaujasST.Name = "MenuItemNaujasST";
            MenuItemNaujasST.Size = new Size(213, 26);
            MenuItemNaujasST.Text = "Naujas Studentas";
            MenuItemNaujasST.Click += MenuItemNaujasST_Click_1;
            // 
            // MenuItemSTsar
            // 
            MenuItemSTsar.BackColor = Color.MediumAquamarine;
            MenuItemSTsar.Name = "MenuItemSTsar";
            MenuItemSTsar.Size = new Size(213, 26);
            MenuItemSTsar.Text = "Studentu Sarasas";
            MenuItemSTsar.Click += MenuItemSTsar_Click;
            // 
            // MenuItemSTATS
            // 
            MenuItemSTATS.BackColor = Color.MediumAquamarine;
            MenuItemSTATS.Name = "MenuItemSTATS";
            MenuItemSTATS.Size = new Size(213, 26);
            MenuItemSTATS.Text = "Statistika";
            MenuItemSTATS.Click += MenuItemSTATS_Click;
            // 
            // redaguotiStudToolStripMenuItem
            // 
            redaguotiStudToolStripMenuItem.BackColor = Color.MediumAquamarine;
            redaguotiStudToolStripMenuItem.Name = "redaguotiStudToolStripMenuItem";
            redaguotiStudToolStripMenuItem.Size = new Size(213, 26);
            redaguotiStudToolStripMenuItem.Text = "Redaguoti Stud.";
            redaguotiStudToolStripMenuItem.Click += redaguotiStudToolStripMenuItem_Click;
            // 
            // MenuItemDalykas
            // 
            MenuItemDalykas.BackColor = SystemColors.Control;
            MenuItemDalykas.DropDownItems.AddRange(new ToolStripItem[] { pridetiDalykaToolStripMenuItem, istrintiDalykaToolStripMenuItem, redaguotiDalykaToolStripMenuItem });
            MenuItemDalykas.Name = "MenuItemDalykas";
            MenuItemDalykas.Size = new Size(82, 25);
            MenuItemDalykas.Text = "Dalykas";
            // 
            // pridetiDalykaToolStripMenuItem
            // 
            pridetiDalykaToolStripMenuItem.BackColor = Color.MediumAquamarine;
            pridetiDalykaToolStripMenuItem.Name = "pridetiDalykaToolStripMenuItem";
            pridetiDalykaToolStripMenuItem.Size = new Size(159, 26);
            pridetiDalykaToolStripMenuItem.Text = "Prideti";
            pridetiDalykaToolStripMenuItem.Click += pridetiDalykaToolStripMenuItem_Click;
            // 
            // istrintiDalykaToolStripMenuItem
            // 
            istrintiDalykaToolStripMenuItem.BackColor = Color.MediumAquamarine;
            istrintiDalykaToolStripMenuItem.Name = "istrintiDalykaToolStripMenuItem";
            istrintiDalykaToolStripMenuItem.Size = new Size(159, 26);
            istrintiDalykaToolStripMenuItem.Text = "Istrinti";
            istrintiDalykaToolStripMenuItem.Click += istrintiDalykaToolStripMenuItem_Click;
            // 
            // redaguotiDalykaToolStripMenuItem
            // 
            redaguotiDalykaToolStripMenuItem.BackColor = Color.MediumAquamarine;
            redaguotiDalykaToolStripMenuItem.Name = "redaguotiDalykaToolStripMenuItem";
            redaguotiDalykaToolStripMenuItem.Size = new Size(159, 26);
            redaguotiDalykaToolStripMenuItem.Text = "Redaguoti";
            redaguotiDalykaToolStripMenuItem.Click += redaguotiDalykaToolStripMenuItem_Click;
            // 
            // MenuItemIvertinimas
            // 
            MenuItemIvertinimas.DropDownItems.AddRange(new ToolStripItem[] { tvarkytiIvertinimusToolStripMenuItem });
            MenuItemIvertinimas.Name = "MenuItemIvertinimas";
            MenuItemIvertinimas.Size = new Size(108, 25);
            MenuItemIvertinimas.Text = "Ivertinimas";
            // 
            // tvarkytiIvertinimusToolStripMenuItem
            // 
            tvarkytiIvertinimusToolStripMenuItem.BackColor = Color.MediumAquamarine;
            tvarkytiIvertinimusToolStripMenuItem.Name = "tvarkytiIvertinimusToolStripMenuItem";
            tvarkytiIvertinimusToolStripMenuItem.Size = new Size(232, 26);
            tvarkytiIvertinimusToolStripMenuItem.Text = "Tvarkyti Ivertinimus";
            tvarkytiIvertinimusToolStripMenuItem.Click += tvarkytiIvertinimusToolStripMenuItem_Click;
            // 
            // MenuItemDestytojas
            // 
            MenuItemDestytojas.DropDownItems.AddRange(new ToolStripItem[] { pRIDETIDESTYTOJAToolStripMenuItem });
            MenuItemDestytojas.Name = "MenuItemDestytojas";
            MenuItemDestytojas.Size = new Size(102, 25);
            MenuItemDestytojas.Text = "Destytojas";
            // 
            // pRIDETIDESTYTOJAToolStripMenuItem
            // 
            pRIDETIDESTYTOJAToolStripMenuItem.BackColor = Color.MediumAquamarine;
            pRIDETIDESTYTOJAToolStripMenuItem.Name = "pRIDETIDESTYTOJAToolStripMenuItem";
            pRIDETIDESTYTOJAToolStripMenuItem.Size = new Size(206, 26);
            pRIDETIDESTYTOJAToolStripMenuItem.Text = "Prideti destytoja";
            pRIDETIDESTYTOJAToolStripMenuItem.Click += pRIDETIDESTYTOJAToolStripMenuItem_Click;
            // 
            // Pagrindinis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 616);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Pagrindinis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagrindinis";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemST;
        private ToolStripMenuItem MenuItemDalykas;
        private ToolStripMenuItem MenuItemIvertinimas;
        private ToolStripMenuItem MenuItemDestytojas;
        private ToolStripMenuItem MenuItemNaujasST;
        private ToolStripMenuItem MenuItemSTsar;
        private ToolStripMenuItem MenuItemSTATS;
        private ToolStripMenuItem redaguotiStudToolStripMenuItem;
        private ToolStripMenuItem pridetiDalykaToolStripMenuItem;
        private ToolStripMenuItem istrintiDalykaToolStripMenuItem;
        private ToolStripMenuItem redaguotiDalykaToolStripMenuItem;
        private ToolStripMenuItem tvarkytiIvertinimusToolStripMenuItem;
        private ToolStripMenuItem pRIDETIDESTYTOJAToolStripMenuItem;
    }
}
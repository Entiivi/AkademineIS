namespace AkademineIS
{
    partial class Statistika
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
            panelVisi = new Panel();
            label1Visi = new Label();
            panelVyr = new Panel();
            labelVyrai = new Label();
            panelNe = new Panel();
            labelNesake = new Label();
            panelMot = new Panel();
            labelMoterys = new Label();
            panelVisi.SuspendLayout();
            panelVyr.SuspendLayout();
            panelNe.SuspendLayout();
            panelMot.SuspendLayout();
            SuspendLayout();
            // 
            // panelVisi
            // 
            panelVisi.BackColor = SystemColors.ButtonShadow;
            panelVisi.BorderStyle = BorderStyle.FixedSingle;
            panelVisi.Controls.Add(label1Visi);
            panelVisi.Location = new Point(0, 0);
            panelVisi.Name = "panelVisi";
            panelVisi.Size = new Size(800, 206);
            panelVisi.TabIndex = 0;
            // 
            // label1Visi
            // 
            label1Visi.AutoSize = true;
            label1Visi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1Visi.Location = new Point(280, 81);
            label1Visi.Name = "label1Visi";
            label1Visi.Size = new Size(244, 32);
            label1Visi.TabIndex = 0;
            label1Visi.Text = "Studentu kiekis: 100";
            label1Visi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelVyr
            // 
            panelVyr.BackColor = SystemColors.ButtonShadow;
            panelVyr.BorderStyle = BorderStyle.FixedSingle;
            panelVyr.Controls.Add(labelVyrai);
            panelVyr.Location = new Point(0, 205);
            panelVyr.Name = "panelVyr";
            panelVyr.Size = new Size(273, 221);
            panelVyr.TabIndex = 1;
            // 
            // labelVyrai
            // 
            labelVyrai.AutoSize = true;
            labelVyrai.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVyrai.Location = new Point(56, 94);
            labelVyrai.Name = "labelVyrai";
            labelVyrai.Size = new Size(136, 32);
            labelVyrai.TabIndex = 1;
            labelVyrai.Text = "Vyrai: 50%";
            labelVyrai.TextAlign = ContentAlignment.MiddleCenter;
            labelVyrai.Click += label1_Click;
            // 
            // panelNe
            // 
            panelNe.BackColor = SystemColors.ButtonShadow;
            panelNe.BorderStyle = BorderStyle.FixedSingle;
            panelNe.Controls.Add(labelNesake);
            panelNe.Location = new Point(541, 205);
            panelNe.Name = "panelNe";
            panelNe.Size = new Size(259, 221);
            panelNe.TabIndex = 2;
            // 
            // labelNesake
            // 
            labelNesake.AutoSize = true;
            labelNesake.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNesake.Location = new Point(57, 93);
            labelNesake.Name = "labelNesake";
            labelNesake.Size = new Size(159, 32);
            labelNesake.TabIndex = 2;
            labelNesake.Text = "Nesake: 50%";
            labelNesake.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMot
            // 
            panelMot.BackColor = SystemColors.ButtonShadow;
            panelMot.BorderStyle = BorderStyle.FixedSingle;
            panelMot.Controls.Add(labelMoterys);
            panelMot.Location = new Point(270, 205);
            panelMot.Name = "panelMot";
            panelMot.Size = new Size(273, 221);
            panelMot.TabIndex = 3;
            // 
            // labelMoterys
            // 
            labelMoterys.AutoSize = true;
            labelMoterys.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMoterys.Location = new Point(57, 93);
            labelMoterys.Name = "labelMoterys";
            labelMoterys.Size = new Size(172, 32);
            labelMoterys.TabIndex = 2;
            labelMoterys.Text = "Moterys: 50%";
            labelMoterys.TextAlign = ContentAlignment.MiddleCenter;
            labelMoterys.Click += label2_Click;
            // 
            // Statistika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 426);
            Controls.Add(panelMot);
            Controls.Add(panelNe);
            Controls.Add(panelVyr);
            Controls.Add(panelVisi);
            Name = "Statistika";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Statistika";
            Load += Statistika_Load;
            panelVisi.ResumeLayout(false);
            panelVisi.PerformLayout();
            panelVyr.ResumeLayout(false);
            panelVyr.PerformLayout();
            panelNe.ResumeLayout(false);
            panelNe.PerformLayout();
            panelMot.ResumeLayout(false);
            panelMot.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVisi;
        private Panel panelVyr;
        private Label label1Visi;
        private Panel panelNe;
        private Label labelVyrai;
        private Label labelNesake;
        private Panel panelMot;
        private Label labelMoterys;
    }
}
namespace AkademineIS
{
    partial class AtnaujintIstrintStud
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
            textBoxPav = new TextBox();
            textBoxVardas = new TextBox();
            Gim = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxID = new TextBox();
            label4 = new Label();
            textBoxAdresas = new TextBox();
            label7 = new Label();
            textBoxNr = new TextBox();
            label6 = new Label();
            textBoxPastas = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonNesake = new RadioButton();
            radioButtonMoteris = new RadioButton();
            radioButtonVyras = new RadioButton();
            label5 = new Label();
            label8 = new Label();
            buttonTrinti = new Button();
            buttonRedag = new Button();
            buttonFind = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPav
            // 
            textBoxPav.Location = new Point(128, 133);
            textBoxPav.Name = "textBoxPav";
            textBoxPav.Size = new Size(274, 23);
            textBoxPav.TabIndex = 13;
            // 
            // textBoxVardas
            // 
            textBoxVardas.Location = new Point(128, 82);
            textBoxVardas.Name = "textBoxVardas";
            textBoxVardas.Size = new Size(275, 23);
            textBoxVardas.TabIndex = 12;
            // 
            // Gim
            // 
            Gim.Location = new Point(128, 183);
            Gim.Name = "Gim";
            Gim.Size = new Size(275, 23);
            Gim.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 183);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 10;
            label3.Text = "Gim. Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 131);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 9;
            label2.Text = "Pavarde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 82);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 8;
            label1.Text = "Vardas:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(128, 39);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(64, 23);
            textBoxID.TabIndex = 15;
            textBoxID.KeyPress += textBoxID_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 39);
            label4.Name = "label4";
            label4.Size = new Size(31, 21);
            label4.TabIndex = 14;
            label4.Text = "ID:";
            // 
            // textBoxAdresas
            // 
            textBoxAdresas.Location = new Point(128, 391);
            textBoxAdresas.Multiline = true;
            textBoxAdresas.Name = "textBoxAdresas";
            textBoxAdresas.Size = new Size(275, 77);
            textBoxAdresas.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 389);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 22;
            label7.Text = "Adresas:";
            // 
            // textBoxNr
            // 
            textBoxNr.Location = new Point(127, 329);
            textBoxNr.Name = "textBoxNr";
            textBoxNr.Size = new Size(274, 23);
            textBoxNr.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 331);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 20;
            label6.Text = "Tel. Nr. :";
            // 
            // textBoxPastas
            // 
            textBoxPastas.Location = new Point(127, 274);
            textBoxPastas.Name = "textBoxPastas";
            textBoxPastas.Size = new Size(274, 23);
            textBoxPastas.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(radioButtonNesake);
            groupBox1.Controls.Add(radioButtonMoteris);
            groupBox1.Controls.Add(radioButtonVyras);
            groupBox1.Location = new Point(128, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 31);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // radioButtonNesake
            // 
            radioButtonNesake.AutoSize = true;
            radioButtonNesake.Location = new Point(135, 10);
            radioButtonNesake.Name = "radioButtonNesake";
            radioButtonNesake.Size = new Size(63, 19);
            radioButtonNesake.TabIndex = 2;
            radioButtonNesake.TabStop = true;
            radioButtonNesake.Text = "Nesake";
            radioButtonNesake.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoteris
            // 
            radioButtonMoteris.AutoSize = true;
            radioButtonMoteris.Location = new Point(64, 10);
            radioButtonMoteris.Name = "radioButtonMoteris";
            radioButtonMoteris.Size = new Size(65, 19);
            radioButtonMoteris.TabIndex = 1;
            radioButtonMoteris.TabStop = true;
            radioButtonMoteris.Text = "Moteris";
            radioButtonMoteris.UseVisualStyleBackColor = true;
            // 
            // radioButtonVyras
            // 
            radioButtonVyras.AutoSize = true;
            radioButtonVyras.Location = new Point(5, 10);
            radioButtonVyras.Name = "radioButtonVyras";
            radioButtonVyras.Size = new Size(53, 19);
            radioButtonVyras.TabIndex = 0;
            radioButtonVyras.TabStop = true;
            radioButtonVyras.Text = "Vyras";
            radioButtonVyras.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 228);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 17;
            label5.Text = "Lytis:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 274);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 16;
            label8.Text = "El. Pastas:";
            // 
            // buttonTrinti
            // 
            buttonTrinti.BackColor = Color.IndianRed;
            buttonTrinti.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonTrinti.FlatStyle = FlatStyle.Flat;
            buttonTrinti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTrinti.Location = new Point(127, 495);
            buttonTrinti.Name = "buttonTrinti";
            buttonTrinti.Size = new Size(121, 50);
            buttonTrinti.TabIndex = 25;
            buttonTrinti.Text = "TRINTI";
            buttonTrinti.UseVisualStyleBackColor = false;
            buttonTrinti.Click += buttonTrinti_Click;
            // 
            // buttonRedag
            // 
            buttonRedag.BackColor = Color.LightGreen;
            buttonRedag.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonRedag.FlatStyle = FlatStyle.Flat;
            buttonRedag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRedag.Location = new Point(282, 495);
            buttonRedag.Name = "buttonRedag";
            buttonRedag.Size = new Size(121, 50);
            buttonRedag.TabIndex = 24;
            buttonRedag.Text = "REDAGUOTI";
            buttonRedag.UseVisualStyleBackColor = false;
            buttonRedag.Click += buttonRedag_Click;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.LightGreen;
            buttonFind.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFind.Location = new Point(205, 39);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(69, 23);
            buttonFind.TabIndex = 26;
            buttonFind.Text = "RASTI";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // AtnaujintIstrintStud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(495, 636);
            Controls.Add(buttonFind);
            Controls.Add(buttonTrinti);
            Controls.Add(buttonRedag);
            Controls.Add(textBoxAdresas);
            Controls.Add(label7);
            Controls.Add(textBoxNr);
            Controls.Add(label6);
            Controls.Add(textBoxPastas);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(textBoxID);
            Controls.Add(label4);
            Controls.Add(textBoxPav);
            Controls.Add(textBoxVardas);
            Controls.Add(Gim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AtnaujintIstrintStud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Redaguoti Sudenta";
            Load += AtnaujintIstrintStud_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private Label label5;
        private Label label8;
        private Button buttonTrinti;
        private Button buttonRedag;
        private Button buttonFind;
        internal TextBox textBoxID;
        internal DateTimePicker Gim;
        internal TextBox textBoxAdresas;
        internal TextBox textBoxNr;
        internal TextBox textBoxPastas;
        internal RadioButton radioButtonNesake;
        internal RadioButton radioButtonMoteris;
        internal RadioButton radioButtonVyras;
        internal TextBox textBoxPav;
        internal TextBox textBoxVardas;
    }
}
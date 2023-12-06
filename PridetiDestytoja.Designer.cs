namespace AkademineIS
{
    partial class PridetiDestytoja
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
            textBoxNr = new TextBox();
            label6 = new Label();
            textBoxPastas = new TextBox();
            textBoxPav = new TextBox();
            textBoxVardas = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonTrinti = new Button();
            buttonIrasyti = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            textBoxID = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNr
            // 
            textBoxNr.Location = new Point(164, 291);
            textBoxNr.Name = "textBoxNr";
            textBoxNr.Size = new Size(274, 23);
            textBoxNr.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 289);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 18;
            label6.Text = "Tel. Nr. :";
            // 
            // textBoxPastas
            // 
            textBoxPastas.Location = new Point(164, 249);
            textBoxPastas.Name = "textBoxPastas";
            textBoxPastas.Size = new Size(274, 23);
            textBoxPastas.TabIndex = 17;
            textBoxPastas.TextChanged += textBoxPastas_TextChanged;
            // 
            // textBoxPav
            // 
            textBoxPav.Location = new Point(165, 199);
            textBoxPav.Name = "textBoxPav";
            textBoxPav.Size = new Size(274, 23);
            textBoxPav.TabIndex = 16;
            // 
            // textBoxVardas
            // 
            textBoxVardas.Location = new Point(164, 142);
            textBoxVardas.Name = "textBoxVardas";
            textBoxVardas.Size = new Size(275, 23);
            textBoxVardas.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 251);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 14;
            label4.Text = "El. Pastas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 197);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 13;
            label2.Text = "Pavarde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 142);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 12;
            label1.Text = "Vardas:";
            // 
            // buttonTrinti
            // 
            buttonTrinti.BackColor = Color.IndianRed;
            buttonTrinti.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonTrinti.FlatStyle = FlatStyle.Flat;
            buttonTrinti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTrinti.Location = new Point(64, 344);
            buttonTrinti.Name = "buttonTrinti";
            buttonTrinti.Size = new Size(121, 50);
            buttonTrinti.TabIndex = 21;
            buttonTrinti.Text = "TRINTI";
            buttonTrinti.UseVisualStyleBackColor = false;
            buttonTrinti.Click += buttonTrinti_Click;
            // 
            // buttonIrasyti
            // 
            buttonIrasyti.BackColor = Color.LightGreen;
            buttonIrasyti.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonIrasyti.FlatStyle = FlatStyle.Flat;
            buttonIrasyti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIrasyti.Location = new Point(318, 344);
            buttonIrasyti.Name = "buttonIrasyti";
            buttonIrasyti.Size = new Size(121, 50);
            buttonIrasyti.TabIndex = 20;
            buttonIrasyti.Text = "IRASYTI";
            buttonIrasyti.UseVisualStyleBackColor = false;
            buttonIrasyti.Click += buttonIrasyti_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 94);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 22;
            label3.Text = "Mokomas dalykas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(274, 23);
            comboBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(615, 370);
            dataGridView1.TabIndex = 24;
            dataGridView1.Click += dataGridView1_Click_1;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(165, 47);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(120, 23);
            textBoxID.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 47);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 25;
            label5.Text = "Dalyko ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(191, 344);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 27;
            button1.Text = "ATNAUJINTI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PridetiDestytoja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1082, 421);
            Controls.Add(button1);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(buttonTrinti);
            Controls.Add(buttonIrasyti);
            Controls.Add(textBoxNr);
            Controls.Add(label6);
            Controls.Add(textBoxPastas);
            Controls.Add(textBoxPav);
            Controls.Add(textBoxVardas);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PridetiDestytoja";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Prideti Destytoja";
            Load += PridetiDestytoja_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNr;
        private Label label6;
        private TextBox textBoxPastas;
        private TextBox textBoxPav;
        private TextBox textBoxVardas;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button buttonTrinti;
        private Button buttonIrasyti;
        private Label label3;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox textBoxID;
        private Label label5;
        private Button button1;
    }
}
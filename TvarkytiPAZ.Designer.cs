namespace AkademineIS
{
    partial class TvarkytiPAZ
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
            textBoxStudID = new TextBox();
            label1 = new Label();
            comboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxApras = new TextBox();
            textBoxPaz = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            buttonTrinti = new Button();
            buttonPrideti = new Button();
            buttonRodStud = new Button();
            buttonRodIvert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxStudID
            // 
            textBoxStudID.Location = new Point(164, 27);
            textBoxStudID.Name = "textBoxStudID";
            textBoxStudID.Size = new Size(201, 23);
            textBoxStudID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 27);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 1;
            label1.Text = "Studento ID:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(164, 69);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(201, 23);
            comboBox.TabIndex = 4;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 5;
            label2.Text = "Pasirinkti dalyka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 111);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "Ivertinimas:";
            // 
            // textBoxApras
            // 
            textBoxApras.Location = new Point(164, 154);
            textBoxApras.Multiline = true;
            textBoxApras.Name = "textBoxApras";
            textBoxApras.Size = new Size(275, 77);
            textBoxApras.TabIndex = 18;
            // 
            // textBoxPaz
            // 
            textBoxPaz.Location = new Point(164, 113);
            textBoxPaz.Name = "textBoxPaz";
            textBoxPaz.Size = new Size(201, 23);
            textBoxPaz.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 154);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 20;
            label4.Text = "Aprasymas:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(466, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(456, 359);
            dataGridView1.TabIndex = 21;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // buttonTrinti
            // 
            buttonTrinti.BackColor = Color.IndianRed;
            buttonTrinti.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonTrinti.FlatStyle = FlatStyle.Flat;
            buttonTrinti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTrinti.Location = new Point(318, 274);
            buttonTrinti.Name = "buttonTrinti";
            buttonTrinti.Size = new Size(121, 50);
            buttonTrinti.TabIndex = 27;
            buttonTrinti.Text = "TRINTI";
            buttonTrinti.UseVisualStyleBackColor = false;
            buttonTrinti.Click += buttonTrinti_Click;
            // 
            // buttonPrideti
            // 
            buttonPrideti.BackColor = Color.LightGreen;
            buttonPrideti.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonPrideti.FlatStyle = FlatStyle.Flat;
            buttonPrideti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrideti.Location = new Point(164, 274);
            buttonPrideti.Name = "buttonPrideti";
            buttonPrideti.Size = new Size(121, 50);
            buttonPrideti.TabIndex = 26;
            buttonPrideti.Text = "PRIDETI";
            buttonPrideti.UseVisualStyleBackColor = false;
            buttonPrideti.Click += buttonPrideti_Click;
            // 
            // buttonRodStud
            // 
            buttonRodStud.Location = new Point(466, 12);
            buttonRodStud.Name = "buttonRodStud";
            buttonRodStud.Size = new Size(139, 36);
            buttonRodStud.TabIndex = 28;
            buttonRodStud.Text = "Rodyti Studentus";
            buttonRodStud.UseVisualStyleBackColor = true;
            buttonRodStud.Click += buttonRodStud_Click;
            // 
            // buttonRodIvert
            // 
            buttonRodIvert.Location = new Point(622, 12);
            buttonRodIvert.Name = "buttonRodIvert";
            buttonRodIvert.Size = new Size(139, 36);
            buttonRodIvert.TabIndex = 29;
            buttonRodIvert.Text = "Rodyti Ivertinimus";
            buttonRodIvert.UseVisualStyleBackColor = true;
            buttonRodIvert.Click += buttonRodIvert_Click;
            // 
            // TvarkytiPAZ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(934, 429);
            Controls.Add(buttonRodIvert);
            Controls.Add(buttonRodStud);
            Controls.Add(buttonTrinti);
            Controls.Add(buttonPrideti);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBoxPaz);
            Controls.Add(textBoxApras);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox);
            Controls.Add(label1);
            Controls.Add(textBoxStudID);
            Name = "TvarkytiPAZ";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ivertinimai";
            Load += TvarkytiPAZ_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStudID;
        private Label label1;
        private ComboBox comboBox;
        private Label label2;
        private Label label3;
        private TextBox textBoxApras;
        private TextBox textBoxPaz;
        private Label label4;
        private DataGridView dataGridView1;
        private Button buttonTrinti;
        private Button buttonPrideti;
        private Button buttonRodStud;
        private Button buttonRodIvert;
    }
}
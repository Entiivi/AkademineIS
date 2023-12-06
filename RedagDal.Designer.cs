namespace AkademineIS
{
    partial class RedagDal
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
            buttonRedagDal = new Button();
            numericUpDownHours = new NumericUpDown();
            label2 = new Label();
            textBoxApras = new TextBox();
            label7 = new Label();
            textBoxDalPav = new TextBox();
            label1 = new Label();
            label4 = new Label();
            comboBoxDal = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // buttonRedagDal
            // 
            buttonRedagDal.BackColor = Color.LightGreen;
            buttonRedagDal.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonRedagDal.FlatStyle = FlatStyle.Flat;
            buttonRedagDal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRedagDal.Location = new Point(187, 344);
            buttonRedagDal.Name = "buttonRedagDal";
            buttonRedagDal.Size = new Size(275, 50);
            buttonRedagDal.TabIndex = 28;
            buttonRedagDal.Text = "REDAGUOTI";
            buttonRedagDal.UseVisualStyleBackColor = false;
            buttonRedagDal.Click += buttonRedagDal_Click;
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownHours.Location = new Point(187, 151);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(120, 29);
            numericUpDownHours.TabIndex = 27;
            numericUpDownHours.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 153);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 26;
            label2.Text = "Valandu skaicius:";
            // 
            // textBoxApras
            // 
            textBoxApras.Location = new Point(187, 217);
            textBoxApras.Multiline = true;
            textBoxApras.Name = "textBoxApras";
            textBoxApras.Size = new Size(275, 77);
            textBoxApras.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(75, 217);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 24;
            label7.Text = "Aprasymas:";
            // 
            // textBoxDalPav
            // 
            textBoxDalPav.Location = new Point(187, 93);
            textBoxDalPav.Name = "textBoxDalPav";
            textBoxDalPav.Size = new Size(275, 23);
            textBoxDalPav.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 90);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 22;
            label1.Text = "Pavadinimas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 47);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 32;
            label4.Text = "Pasirinkite Dalyka:";
            // 
            // comboBoxDal
            // 
            comboBoxDal.FormattingEnabled = true;
            comboBoxDal.Location = new Point(187, 47);
            comboBoxDal.Name = "comboBoxDal";
            comboBoxDal.Size = new Size(275, 23);
            comboBoxDal.TabIndex = 34;
            comboBoxDal.SelectedIndexChanged += comboBoxDal_SelectedIndexChanged;
            // 
            // RedagDal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(591, 454);
            Controls.Add(comboBoxDal);
            Controls.Add(label4);
            Controls.Add(buttonRedagDal);
            Controls.Add(numericUpDownHours);
            Controls.Add(label2);
            Controls.Add(textBoxApras);
            Controls.Add(label7);
            Controls.Add(textBoxDalPav);
            Controls.Add(label1);
            Name = "RedagDal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RedagDal";
            Load += RedagDal_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRedagDal;
        private NumericUpDown numericUpDownHours;
        private Label label2;
        private TextBox textBoxApras;
        private Label label7;
        private TextBox textBoxDalPav;
        private Label label1;
        private Label label4;
        private ComboBox comboBoxDal;
    }
}
namespace AkademineIS
{
    partial class PridetiDalyka
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
            textBoxApras = new TextBox();
            label7 = new Label();
            textBoxDalPav = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDownHours = new NumericUpDown();
            buttonIrasytiDal = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).BeginInit();
            SuspendLayout();
            // 
            // textBoxApras
            // 
            textBoxApras.Location = new Point(168, 136);
            textBoxApras.Multiline = true;
            textBoxApras.Name = "textBoxApras";
            textBoxApras.Size = new Size(275, 77);
            textBoxApras.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(56, 136);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 16;
            label7.Text = "Aprasymas:";
            // 
            // textBoxDalPav
            // 
            textBoxDalPav.Location = new Point(168, 12);
            textBoxDalPav.Name = "textBoxDalPav";
            textBoxDalPav.Size = new Size(275, 23);
            textBoxDalPav.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 14;
            label1.Text = "Pavadinimas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 18;
            label2.Text = "Valandu skaicius:";
            // 
            // numericUpDownHours
            // 
            numericUpDownHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDownHours.Location = new Point(168, 75);
            numericUpDownHours.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHours.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHours.Name = "numericUpDownHours";
            numericUpDownHours.Size = new Size(120, 29);
            numericUpDownHours.TabIndex = 20;
            numericUpDownHours.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // buttonIrasytiDal
            // 
            buttonIrasytiDal.BackColor = Color.LightGreen;
            buttonIrasytiDal.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonIrasytiDal.FlatStyle = FlatStyle.Flat;
            buttonIrasytiDal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIrasytiDal.Location = new Point(168, 263);
            buttonIrasytiDal.Name = "buttonIrasytiDal";
            buttonIrasytiDal.Size = new Size(275, 50);
            buttonIrasytiDal.TabIndex = 21;
            buttonIrasytiDal.Text = "IRASYTI";
            buttonIrasytiDal.UseVisualStyleBackColor = false;
            buttonIrasytiDal.Click += buttonIrasytiDal_Click;
            // 
            // PridetiDalyka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(465, 351);
            Controls.Add(buttonIrasytiDal);
            Controls.Add(numericUpDownHours);
            Controls.Add(label2);
            Controls.Add(textBoxApras);
            Controls.Add(label7);
            Controls.Add(textBoxDalPav);
            Controls.Add(label1);
            Name = "PridetiDalyka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prideti Dalyka";
            Load += PridetiDalyka_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxApras;
        private Label label7;
        private TextBox textBoxDalPav;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownHours;
        private Button buttonIrasytiDal;
    }
}
namespace AkademineIS
{
    partial class IstrintiDal
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
            buttonIstrintiDal = new Button();
            textBoxID = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonIstrintiDal
            // 
            buttonIstrintiDal.BackColor = Color.FromArgb(255, 128, 128);
            buttonIstrintiDal.FlatAppearance.MouseOverBackColor = Color.Lime;
            buttonIstrintiDal.FlatStyle = FlatStyle.Flat;
            buttonIstrintiDal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIstrintiDal.Location = new Point(281, 15);
            buttonIstrintiDal.Name = "buttonIstrintiDal";
            buttonIstrintiDal.Size = new Size(120, 31);
            buttonIstrintiDal.TabIndex = 29;
            buttonIstrintiDal.Text = "ISTRINTI";
            buttonIstrintiDal.UseVisualStyleBackColor = false;
            buttonIstrintiDal.Click += buttonIstrintiDal_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(192, 20);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(64, 23);
            textBoxID.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 20);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 30;
            label4.Text = "Iveskite Dalyko ID:";
            // 
            // IstrintiDal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(500, 65);
            Controls.Add(textBoxID);
            Controls.Add(label4);
            Controls.Add(buttonIstrintiDal);
            Name = "IstrintiDal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Istrinti Dalyka";
            Load += IstrintiDal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonIstrintiDal;
        internal TextBox textBoxID;
        private Label label4;
    }
}
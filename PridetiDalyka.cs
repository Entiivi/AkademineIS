using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineIS
{
    public partial class PridetiDalyka : Form
    {
        public PridetiDalyka()
        {
            InitializeComponent();
        }

        private void buttonIrasytiDal_Click(object sender, EventArgs e)
        {
            string DalPav = textBoxDalPav.Text;
            int val = (int)numericUpDownHours.Value;
            string ap = textBoxApras.Text;

            Dalykas dalykas = new Dalykas();

            if (DalPav.Trim() == "" || ap.Trim() == "")
            {
                MessageBox.Show("Dalyko pavadinimo ir aprasymo laukai turi but uzpildyti", "Irasyti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(dalykas.checkDalPav(DalPav))
            {
                if (dalykas.IrasytiDalyka(DalPav, val, ap))
                {
                    MessageBox.Show("Dalykas irasytas", "Irasyti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dalykas neirasytas", "Irasyti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sitas Dalyko pavadinimas egzistuoja", "Irasyti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void PridetiDalyka_Load(object sender, EventArgs e)
        {

        }
    }
}

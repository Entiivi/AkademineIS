using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AkademineIS
{
    public partial class IstrintiDal : Form
    {
        public IstrintiDal()
        {
            InitializeComponent();
        }

        private void IstrintiDal_Load(object sender, EventArgs e)
        {

        }

        private void buttonIrasytiDal_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownHours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDalPav_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIstrintiDal_Click(object sender, EventArgs e)
        {
            try
            {
                int dalID = Convert.ToInt32(textBoxID.Text);
                Dalykas dalykas = new Dalykas();
                if (MessageBox.Show("Ar tikrai norite istrinti si dalyka", "Istrinti dalyka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dalykas.istrintiDal(dalID))
                    {
                        MessageBox.Show("Dalykas Istrintas", "Istrinti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dalykas nebuvo istrintas", "Istrinti dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Iveskite tinkama Dalyko ID", "Istrinti dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

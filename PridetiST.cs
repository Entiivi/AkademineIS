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
    public partial class PridetiST : Form
    {
        public PridetiST()
        {
            InitializeComponent();
        }

        private void buttonIrasyti_Click(object sender, EventArgs e)
        {
            //prideti stud
            STUDENTAS studentas = new STUDENTAS();
            string vardas = textBoxVardas.Text;
            string pav = textBoxPav.Text;
            DateTime gim = Gim.Value;
            string nr = textBoxNr.Text;
            string adresas = textBoxAdresas.Text;
            string mail = textBoxPastas.Text;
            string lytis = "Vyras";

            if (radioButtonMoteris.Checked)
            {
                lytis = "Moteris";
            }

            if (radioButtonNesake.Checked)
            {
                lytis = "Nesake";
            }


            int gim_metai = Gim.Value.Year;
            int dbr_metai = DateTime.Now.Year;

            if (dbr_metai - gim_metai <= 18 || ((dbr_metai - gim_metai) > 100))
            {
                MessageBox.Show("Studentas turi but 18 metu arba vyresnis", "Ivesti netinkami gimimo metai.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (studentas.insertStudentas(vardas, pav, gim, lytis, mail, nr, adresas))
                {
                    MessageBox.Show("Naujas Studentas Pridetas", "Prideti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "Prideti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Visi informacijos langeliai turi but u zpildyti", "Prideti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //sukrut func patikrint data
        bool verif()
        {
            if (
                textBoxVardas.Text.Trim() == "" ||
                textBoxPav.Text.Trim() == "" ||
                textBoxNr.Text.Trim() == "" ||
                textBoxAdresas.Text.Trim() == ""
              )
            {
                return false;
            }
            else
            {
                return true;
            };
        }
        private void buttonAtgal_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}

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
    public partial class AtnaujintIstrintStud : Form
    {
        public AtnaujintIstrintStud()
        {
            InitializeComponent();
        }

        STUDENTAS studentas = new STUDENTAS();
        private void AtnaujintIstrintStud_Load(object sender, EventArgs e)
        {

        }

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
        private void buttonRedag_Click(object sender, EventArgs e)
        {
            // atnaujinti pasirinkto stud info
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
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
                    if (studentas.updatestudentas(id, vardas, pav, gim, lytis, mail, nr, adresas))
                    {
                        MessageBox.Show("Studento informacija atnaujinta", "Redaguoti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Redaguoti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Visi informacijos langeliai turi but u zpildyti", "Redaguoti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch 
            {
                MessageBox.Show("Iveskite tinkama ID", "Redaguoti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void buttonTrinti_Click(object sender, EventArgs e)
        {
            // istrinti pasirinkta stud
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                //patvirtinimas pries negriztama operacija
                if (MessageBox.Show("Ar tikrai norite istrinti si studenta ?", "Istrinti Stud", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (studentas.deleteStudent(id))
                    {
                        MessageBox.Show("Studentas istrintas", "Istrinti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ISTRINAM LAUKUS
                        textBoxID.Text = "";
                        textBoxVardas.Text = "";
                        textBoxPav.Text = "";
                        Gim.Value = DateTime.Now;
                        textBoxPastas.Text = "";
                        textBoxNr.Text = "";
                        textBoxAdresas.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Studentas nebuvo istrintas", "Istrinti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch
            {
                MessageBox.Show("Iveskite tinkama ID", "Istrinti Studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {


                //ieskot stud pagal id
                 int id = Convert.ToInt32(textBoxID.Text);
                 MySqlCommand command = new MySqlCommand("SELECT `id`, `vardas`, `pav`, `gim`, `lytis`, `mail`, `nr`, `adresas` FROM `studentas` WHERE `id` =" + id);

                 DataTable table = studentas.getstudentas(command);

                 if (table.Rows.Count > 0)
                 {
                     textBoxVardas.Text = table.Rows[0]["vardas"].ToString();
                     textBoxPav.Text = table.Rows[0]["pav"].ToString();
                     textBoxPastas.Text = table.Rows[0]["mail"].ToString();
                     textBoxNr.Text = table.Rows[0]["nr"].ToString();
                     textBoxAdresas.Text = table.Rows[0]["adresas"].ToString();

                     Gim.Value = (DateTime)table.Rows[0]["gim"];

                     // lytis

                     if (table.Rows[0]["lytis"].ToString() == "Vyras")
                     {
                         radioButtonVyras.Checked = true;
                     }
                     if (table.Rows[0]["lytis"].ToString() == "Moteris")
                     {
                         radioButtonMoteris.Checked = true;
                     }
                     if (table.Rows[0]["lytis"].ToString() == "Nesake")
                     {
                         radioButtonNesake.Checked = true;
                     }


                 }


            }catch 
            {
                MessageBox.Show("Iveskite tinkama ID", "Netinkamas ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // leisti ivedinet tik sk. ID texto skiltyje
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

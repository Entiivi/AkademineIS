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
    public partial class RedagDal : Form
    {
        public RedagDal()
        {
            InitializeComponent();
        }

        Dalykas Dalykas = new Dalykas();


        private void RedagDal_Load(object sender, EventArgs e)
        {
            //duoti comboboxui ka rodyt
            comboBoxDal.DataSource = Dalykas.pasimtVDAL();
            comboBoxDal.DisplayMember = "pav";
            comboBoxDal.ValueMember = "id";

            //nustatom pasirinkta dalyka is combobox
            comboBoxDal.SelectedItem = null;
        }

        // SUKURIAM funkcija atnaujinti combobox
        public void fillCombo()
        {
            comboBoxDal.DataSource = Dalykas.pasimtVDAL();
            comboBoxDal.DisplayMember = "pav";
            comboBoxDal.ValueMember = "id";
        }
        private void buttonRedagDal_Click(object sender, EventArgs e)
        {
            try
            {
                // atnaujinam pasirinkta dalyka
                string name = textBoxDalPav.Text;
                int val = (int)numericUpDownHours.Value;
                string apras = textBoxApras.Text;
                int id = (int)comboBoxDal.SelectedValue;

                if(name.Trim() != "")
                {
                    // patikrinti ar dalykao pav jau egzsituoja ir jis nera dabartinis dalykas naudojant id
                    if (!Dalykas.checkDalPav(name, id))
                    {
                        MessageBox.Show("Sitas Dalyko pavadinimas egzistuoja", "Redaguoti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Dalykas.updateDal(id, name, val, apras))
                        {
                            MessageBox.Show("Dalykas atnaujintas", "Redaguoti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillCombo();
                        }
                        else
                        {
                            MessageBox.Show("Dalykas neatnaujintas", "Redaguoti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Iveskite dalyko pavadinima", "Redaguoti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }catch
            {
                MessageBox.Show("Dalykas nebuvo pasirinktas", "Redaguoti Dalyka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboBoxDal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //parodyti pasirinkta dalyko data
                int id = Convert.ToInt32(comboBoxDal.SelectedValue);
                DataTable table = new DataTable();
                table = Dalykas.pasimtDALsuID(id);
                textBoxDalPav.Text = table.Rows[0][1].ToString();
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxApras.Text = table.Rows[0][3].ToString();
            }
            catch
            {

            }
        }
    }
}


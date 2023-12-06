using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AkademineIS
{
    public partial class PridetiDestytoja : Form
    {
        public PridetiDestytoja()
        {
            InitializeComponent();
        }

        private void textBoxPastas_TextChanged(object sender, EventArgs e)
        {

        }

        Destytojas destytojas = new Destytojas();
        Dalykas dalykas = new Dalykas();
        private void buttonIrasyti_Click(object sender, EventArgs e)
        {
            //prideti destytoja


            try
            {

                int dalykasID = Convert.ToInt32(comboBox1.SelectedValue);
                string vardas = Convert.ToString(textBoxVardas.Text);
                string pav = Convert.ToString(textBoxPav.Text);
                string mail = Convert.ToString(textBoxPastas.Text);
                string nr = Convert.ToString(textBoxNr.Text);

                //patikinti ar pazymis is to dalyko jau egzistuoja pas studenta
                if (vardas.Trim() != "" || pav.Trim() != "" || mail.Trim() != "" || nr.Trim() != "")
                {
                    if (!destytojas.DalDesYra(dalykasID))
                    {
                        if (destytojas.ikistDest(dalykasID, vardas, pav, mail, nr))
                        {
                            MessageBox.Show("Destytojas irasytas", "Irasyti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MySqlCommand command = new MySqlCommand("SELECT `dalykasID`, `vardas`, `pav`, `mail`, `nr` FROM `destytojas`");
                            dataGridView1.DataSource = destytojas.getdes(command);
                        }
                        else
                        {
                            MessageBox.Show("Destytoajs nebuvo irasytas", "Irasyti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pasirinktas dalykas jau turi destytoja", "Irasyti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Visi informacijos laukeliai turi but uzpildyti", "Irasyti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PridetiDestytoja_Load(object sender, EventArgs e)
        {
            //duodam combox data dalyku
            comboBox1.DataSource = dalykas.pasimtVDAL();
            comboBox1.DisplayMember = "pav";
            comboBox1.ValueMember = "id";
            //duoti data gridview destytoju data (dalyko id, vardas, pavarde, mail, nr)
            MySqlCommand command = new MySqlCommand("SELECT `dalykasID`, `vardas`, `pav`, `mail`, `nr` FROM `destytojas`");
            dataGridView1.DataSource = destytojas.getdes(command);
            comboBox1.SelectedItem = null;
        }


        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            //pasimt id is pasirinkto studento
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value;
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxVardas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPav.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPastas.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxNr.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void buttonTrinti_Click(object sender, EventArgs e)
        {
            try
            {
                
                int dalykasID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show("Ar tikrai norite istrini pasirinkta destytoja ?", "Istrinti destytoja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (destytojas.istrintiDest(dalykasID))
                    {
                        MessageBox.Show("Ivertinimas Istrintas", "Istrinti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MySqlCommand command = new MySqlCommand("SELECT `dalykasID`, `vardas`, `pav`, `mail`, `nr` FROM `destytojas`");
                        dataGridView1.DataSource = destytojas.getdes(command);
                    }
                    else
                    {
                        MessageBox.Show("Destytojas nebuvo istrintas", "Istrinti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Pasirinkite destytoja kuri norite istrinti", "Istrinti destytoja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string vardas = textBoxVardas.Text;
                string pav = textBoxPav.Text;
                string nr = textBoxNr.Text;
                string mail = textBoxPastas.Text;



                if (vardas.Trim() != "" && pav.Trim() != "" && mail.Trim() != "" && nr.Trim() != "")
                {
                    if (destytojas.updateDes(id, vardas, pav, mail, nr))
                    {
                        MessageBox.Show("Destytojo informacija atnaujinta", "Redaguoti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MySqlCommand command = new MySqlCommand("SELECT `dalykasID`, `vardas`, `pav`, `mail`, `nr` FROM `destytojas`");
                        dataGridView1.DataSource = destytojas.getdes(command);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Redaguoti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Visi informacijos langeliai turi but uzpildyti", "Redaguoti Destytoja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
}

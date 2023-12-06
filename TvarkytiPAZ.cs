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
using Org.BouncyCastle.Asn1.Ocsp;

namespace AkademineIS
{
    public partial class TvarkytiPAZ : Form
    {
        public TvarkytiPAZ()
        {
            InitializeComponent();
        }

        Ivertinimas iver = new Ivertinimas();
        Dalykas dalykas = new Dalykas();
        STUDENTAS STUDENTAS = new STUDENTAS();

        private void TvarkytiPAZ_Load(object sender, EventArgs e)
        {
            //duodam combox data dalyku
            comboBox.DataSource = dalykas.pasimtVDAL();
            comboBox.DisplayMember = "pav";
            comboBox.ValueMember = "id";
            //duoti data gridview studentu data (id, vardas, pavarde)
            MySqlCommand command = new MySqlCommand("SELECT `id`, `vardas`, `pav` FROM `studentas`");
            dataGridView1.DataSource = STUDENTAS.getstudentas(command);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //pasimt id is pasirinkto studento
            textBoxStudID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonPrideti_Click(object sender, EventArgs e)
        {
            // pridedam nauja ivertinima
            try
            {
                int studentID = Convert.ToInt32(textBoxStudID.Text);
                int dalykasID = Convert.ToInt32(comboBox.SelectedValue);
                double ivert = Convert.ToDouble(textBoxPaz.Text);
                string apras = textBoxApras.Text;

                //patikinti ar pazymis is to dalyko jau egzistuoja pas studenta
                if (!iver.studIvertYra(studentID, dalykasID))
                {
                    if (iver.ikistIvert(studentID, dalykasID, ivert, apras))
                    {
                        MessageBox.Show("Ivertinimas irasytas", "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ivertinimas.imamStIver();
                    }
                    else
                    {
                        MessageBox.Show("Ivertinimas nebuvo irasytas", "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Pasirinktas studentas jau turi ivertinima is sito dalyko", "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Irasyti Ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonTrinti_Click(object sender, EventArgs e)
        {
            //istrintam pasirinkta ivert
            try
            {
                int studantID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int dalykasID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                if (MessageBox.Show("Ar tikrai norite istrini pasirinkta ivertinima ?", "Istrinti ivertinima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ivertinimas.istrintiIvert(studantID, dalykasID))
                    {
                        MessageBox.Show("Ivertinimas Istrintas", "Istrinti ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ivertinimas.imamStIver();
                    }
                    else
                    {
                        MessageBox.Show("Ivertinimas nebuvo istrintas", "Istrinti ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Pasirinkite Stud Ivertinma kuri norite istrinti is Ivertinimu skilties", "Istrinti ivertinima", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        Ivertinimas ivertinimas = new Ivertinimas();
        private void buttonRodIvert_Click(object sender, EventArgs e)
        {
            //rodom pazymius su std
            dataGridView1.DataSource = ivertinimas.imamStIver();
        }

        private void buttonRodStud_Click(object sender, EventArgs e)
        {
            //duodam combox data dalyku
            comboBox.DataSource = dalykas.pasimtVDAL();
            comboBox.DisplayMember = "pav";
            comboBox.ValueMember = "id";
            //duoti data gridview studentu data (id, vardas, pavarde)
            MySqlCommand command = new MySqlCommand("SELECT `id`, `vardas`, `pav` FROM `studentas`");
            dataGridView1.DataSource = STUDENTAS.getstudentas(command);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

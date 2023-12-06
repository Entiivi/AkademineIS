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
    public partial class StudSar : Form
    {
        public StudSar()
        {
            InitializeComponent();
        }

        STUDENTAS studentas = new STUDENTAS();
        private void StudSar_Load(object sender, EventArgs e)
        {
            // priskiriam data rodyum sarase su studentu data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studentas`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = studentas.getstudentas(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // rodyti pasirinkta studenta naujoje formoje editinimui
            AtnaujintIstrintStud atnaujintIstrintStud = new AtnaujintIstrintStud();
            atnaujintIstrintStud.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            atnaujintIstrintStud.textBoxVardas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            atnaujintIstrintStud.textBoxPav.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            atnaujintIstrintStud.Gim.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;


            //lytis
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Moteris")
            {
                atnaujintIstrintStud.radioButtonMoteris.Checked = true;
            }
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Vyras")
            {
                atnaujintIstrintStud.radioButtonVyras.Checked = true;
            }
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Nesake")
            {
                atnaujintIstrintStud.radioButtonNesake.Checked = true;
            }
            atnaujintIstrintStud.textBoxPastas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            atnaujintIstrintStud.textBoxNr.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            atnaujintIstrintStud.textBoxAdresas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            atnaujintIstrintStud.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //atnaujinti saraso data
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studentas`");
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = studentas.getstudentas(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
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
    public partial class StudentoPagrindinis : Form
    {
        MY_DB mydb = new MY_DB();
        public StudentoPagrindinis()
        {
            InitializeComponent();
        }

        private void StudentoPagrindinis_Load(object sender, EventArgs e)
        {

            Login_Form fLogin = new Login_Form();
            MySqlCommand command = new MySqlCommand("select score.studentasID,studentas.vardas,studentas.pav,score.dalykasID,dalykas.pav,score.ivert from studentas INNER JOIN score ON studentas.id= score.studentasID INNER JOIN dalykas ON score.dalykasID = dalykas.id WHERE studentas.vardas = @Vard;");
            command.Connection = mydb.getConnection;
            string VD = "Ignas";
            string PS = "Sakalauskas";
            command.Parameters.Add("@Vard", MySqlDbType.VarChar).Value = VD;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PS;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            
        }
    }
}

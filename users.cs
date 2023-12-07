using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineIS
{
    internal class users
    {
        MY_DB mydb = new MY_DB();
        
        public bool checkIfStud(string vardas, string pav)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studentas` WHERE `vardas` = @vard AND `pav` = @pav", mydb.getConnection);

            command.Parameters.Add("@vard", MySqlDbType.VarChar).Value = vardas;

            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                //return false jai sitas dalyko pav egzistuoja leidziam prisijungt kaip stud
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}

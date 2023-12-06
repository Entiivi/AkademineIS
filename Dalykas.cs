using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace AkademineIS
{
    internal class Dalykas
    {

        MY_DB mydb = new MY_DB();

        //sukuriam funkcija irasyti dalyka i db

        public bool IrasytiDalyka(string pav, int valnr, string ap)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `dalykas`(`pav`, `valnr`, `ap`) VALUES (@pav,@valnr,@ap)", mydb.getConnection);

            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@valnr", MySqlDbType.Int32).Value = valnr;
            command.Parameters.Add("@ap", MySqlDbType.Text).Value = ap;

            mydb.openConnection();
            
            if(command.ExecuteNonQuery() == 1) 
            {
                mydb.closeConnection();
                return true;

            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        // sukuriam funkcija patikrint ar dalyko pavadinimas jau egzistuoja
        // kada redaguojam reikia nenaudot sito verif pavadinimui
        //nustatysim deflt value id = 0
        public bool checkDalPav(string pav, int dalID = 0)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dalykas` WHERE `pav` = @pav AND id <> @dalID", mydb.getConnection);

            command.Parameters.Add("@dalID",MySqlDbType.Int32).Value = dalID;

            command.Parameters.Add("@pav",MySqlDbType.VarChar).Value = pav;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                mydb.closeConnection();
                //return false jai sitas dalyko pav egzistuoja
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }

        //funkcija istrinti dalyka su id
        public bool istrintiDal(int dalID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `dalykas` WHERE `id`=@dalID", mydb.getConnection);
            command.Parameters.Add("@dalID",MySqlDbType.Int32 ).Value = dalID;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1) { mydb.closeConnection(); return true; } else { mydb.closeConnection(); return false; }
        }
        // sukuriam funkcija pasiimti visus dalykus
        public DataTable pasimtVDAL()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dalykas`",mydb.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // sukuriam funkcija pasiimti dalyka naudojant id
        public DataTable pasimtDALsuID(int dalID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `dalykas` WHERE id = @did", mydb.getConnection);

            command.Parameters.Add("did",MySqlDbType.Int32).Value = dalID; 

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //sukuriam funkcija redaguoti pasirinkta dalyka
        public bool updateDal(int dalID,String pav, int valnr, string ap)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `dalykas` SET `pav`=@pav,`valnr`=@valnr,`ap`=@ap WHERE `id` = @dalID", mydb.getConnection);

            command.Parameters.Add("@dalID", MySqlDbType.Int32).Value = dalID;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@valnr", MySqlDbType.Int32).Value = valnr;
            command.Parameters.Add("@ap", MySqlDbType.Text).Value = ap;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
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

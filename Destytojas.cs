using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineIS
{
    internal class Destytojas
    {
        MY_DB mydb = new MY_DB();
        public bool ikistDest(int dalykasID,string vardas,string pav,string mail,string nr)
        {
            //INSERT INTO `destytojas`(`studentasID`, `dalykasID`, `ivert`, `apras`) VALUES (@sid,@did,@ivert,@apras)
            MySqlCommand command = new MySqlCommand("INSERT INTO `destytojas`(`dalykasID`, `vardas`, `pav`, `mail`, `nr`) VALUES (@did,@vard,@pav,@mail,@nr)", mydb.getConnection);
            command.Parameters.Add("@did", MySqlDbType.Int32).Value = dalykasID;
            command.Parameters.Add("@vard", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = nr;

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

        public bool DalDesYra(int dalykasID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `destytojas` WHERE `dalykasID` = @did", mydb.getConnection);

            
            command.Parameters.Add("@did", MySqlDbType.Int32).Value = dalykasID;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {

                return false;

            }
            else
            {

                return true;
            }
        }
        public DataTable getdes(MySqlCommand command)
        {
            command.Connection = mydb.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
        public bool updateDes(int dalykasID, string vardas, string pav, string mail, string nr)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `destytojas` SET `vardas`=@var,`pav`=@pav,`mail`=@mail,`nr`=@nr WHERE `dalykasID`=@dalykoID", mydb.getConnection);

            //@id, @var,@pav,@gim,@lyt,@mail,@nr,@adres

            command.Parameters.Add("@dalykoID", MySqlDbType.Int32).Value = dalykasID;
            command.Parameters.Add("@var", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = nr;
           

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
        public bool istrintiDest(int did)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `destytojas` WHERE `dalykasID`=@did", mydb.getConnection);

            command.Parameters.Add("@did", MySqlDbType.Int32).Value = did;
            //command.Parameters.Add("@var", MySqlDbType.Int32).Value = var;
            //command.Parameters.Add("@pav", MySqlDbType.Int32).Value = pav;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1) { mydb.closeConnection(); return true; } else { mydb.closeConnection(); return false; }
        }
    }
}

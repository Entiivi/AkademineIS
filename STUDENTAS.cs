using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineIS
{
    internal class STUDENTAS
    {
        //SUKRUT FUNKCIJA PRIDETI STUDENTA I DUOM BAZE
        MY_DB DB = new MY_DB();
        public bool insertStudentas(string vardas, string pav, DateTime gim, string lytis, string mail, string nr, string adresas)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `studentas`(`vardas`, `pav`, `gim`, `lytis`, `mail`, `nr`, `adresas`) VALUES (@var,@pav,@gim,@lyt,@mail,@nr,@adres)", DB.getConnection);

            //priskiriam sitiem @var,@pav,@gim,@lyt,@mail,@nr,@adres data

            command.Parameters.Add("@var", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@gim", MySqlDbType.Date).Value = gim;
            command.Parameters.Add("@lyt", MySqlDbType.VarChar).Value = lytis;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = nr;
            command.Parameters.Add("@adres", MySqlDbType.Text).Value = adresas;

            DB.openConnection();

            if(command.ExecuteNonQuery() == 1) 
            {
                DB.closeConnection();
                return true;    
            }
            else
            {
                DB.closeConnection();
                return false;
            }

           
        }
        // sukuriam func grazinti studentu sraraso data
        public DataTable getstudentas(MySqlCommand command)
        {
            command.Connection = DB.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table; 

        }
        //sukurt funkcija atnaujinti stud info
        public bool updatestudentas(int id, string vardas, string pav, DateTime gim, string lytis, string mail, string nr, string adresas)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `studentas` SET `vardas`=@var,`pav`=@pav,`gim`=@gim,`lytis`=@lyt,`mail`=@mail,`nr`=@nr,`adresas`=@adres WHERE `id`=@ID", DB.getConnection);

            //@id, @var,@pav,@gim,@lyt,@mail,@nr,@adres

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@var", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pav;
            command.Parameters.Add("@gim", MySqlDbType.Date).Value = gim;
            command.Parameters.Add("@lyt", MySqlDbType.VarChar).Value = lytis;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
            command.Parameters.Add("@nr", MySqlDbType.VarChar).Value = nr;
            command.Parameters.Add("@adres", MySqlDbType.Text).Value = adresas;

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DB.closeConnection();
                return true;
            }
            else
            {
                DB.closeConnection();
                return false;
            }
        }
        //sukurti funkcija istrinti pasirinkta stud
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `studentas` WHERE `id`=@studentasID", DB.getConnection);

            //@studentasID

            command.Parameters.Add("@studentasID", MySqlDbType.Int32).Value = id;


            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                DB.closeConnection();
                return true;
            }
            else
            {
                DB.closeConnection();
                return false;
            }
        }

        // sukuruiam funckcija paleisti uzklausa
        public string ExecCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, DB.getConnection);

            DB.openConnection();
            string count = command.ExecuteScalar().ToString();
            DB.closeConnection();

            return count;

        }

        //pasimti total stud skaiciu
        public string VisiStud()
        {
            return ExecCount("SELECT COUNT(*) FROM `studentas`");
        }

        //pasimti vyru skaiciu
        public string VyrStud()
        {
            return ExecCount("SELECT COUNT(*) FROM `studentas` WHERE `lytis`='Vyras'");
        }

        //pasimti moteru skaiciu
        public string MotStud()
        {
            return ExecCount("SELECT COUNT(*) FROM `studentas` WHERE `lytis` = 'Moteris'");
        }

        //pasimti nesake skaiciu
        public string NeStud()
        {
            return ExecCount("SELECT COUNT(*) FROM `studentas` WHERE `lytis`='Nesake'");
        }

    }
}

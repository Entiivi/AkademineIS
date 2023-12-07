using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
namespace AkademineIS
{
    internal class Ivertinimas
    {
        MY_DB mydb = new MY_DB();

        //sukuriam funkcija ikisti nauja ivertinima
        public bool ikistIvert(int studentID, int dalykasID, double ivert, string apras)
        {
            //INSERT INTO `score`(`studentasID`, `dalykasID`, `ivert`, `apras`) VALUES (@sid,@did,@ivert,@apras)
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`studentasID`, `dalykasID`, `ivert`, `apras`) VALUES (@sid,@did,@ivert,@apras)", mydb.getConnection);
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@did", MySqlDbType.Int32).Value = dalykasID;
            command.Parameters.Add("@ivert", MySqlDbType.Double).Value = ivert;
            command.Parameters.Add("@apras", MySqlDbType.VarChar).Value = apras;

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
        //sukuriam funkcija patikinti ar pazymis is to dalyko jau egzistuoja pas studenta
        public bool studIvertYra(int studentID, int dalykasID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `studentasID` = @sid AND `dalykasID` = @did", mydb.getConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
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
        //sukuriam funkcija pssimt ivert stud
        public DataTable imamStIver()
        {
            
            MySqlCommand command = new MySqlCommand("select score.studentasID,studentas.vardas,studentas.pav,score.dalykasID,dalykas.pav,score.ivert\r\nfrom studentas INNER JOIN score ON studentas.id= score.studentasID INNER JOIN dalykas ON score.dalykasID = dalykas.id");
            command.Connection = mydb.getConnection;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        public bool istrintiIvert(int sid, int did)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `studentasID`=@sid AND `dalykasID` =@did", mydb.getConnection);
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = sid;
            command.Parameters.Add("@did", MySqlDbType.Int32).Value = did;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1) { mydb.closeConnection(); return true; } else { mydb.closeConnection(); return false; }
        }


    } 
}

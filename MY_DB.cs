using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AkademineIS
{
    /* 
     *  CIA KLASE KURI SUJINGS DUOMBAZE SU SITU VISU THING (mYSQL IR APP)
     *  PRIDESI MMYSQL PRISIJUGNIMA PRIE PROJEKTO
     *  
     */
    internal class MY_DB
    {
        // prisijungimas
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=akademineis");

        // prisijungimo gavimas

        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        // funkcija atidaryt IR UZDARYTI prisijungimui

        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if( con.State == ConnectionState.Open )
            {
                con.Close();
            }
        }

    }
}

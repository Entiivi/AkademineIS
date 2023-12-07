using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;

namespace AkademineIS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Login_Form());
            Login_Form fLogin = new Login_Form();

            users user = new users();

            if(fLogin.ShowDialog() == DialogResult.OK)
            {

                if (user.checkIfStud(fLogin.vardas, fLogin.pass))
                {
                    Application.Run(new StudentoPagrindinis());
                    
                  
                    
                }
                else if(fLogin.vardas == "admin" &&  fLogin.pass == "admin")
                {
                    Application.Run(new Pagrindinis());
                }
                

            }
            else
            {
                Application.Exit();
            }
            

        }
        

    }
}

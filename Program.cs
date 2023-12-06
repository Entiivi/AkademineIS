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

            if(fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Pagrindinis());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
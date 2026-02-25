namespace SynqPlataform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();


            if (login.ShowDialog() == DialogResult.OK) {
                Application.Run(new FormPrincipal());
            }
            else {

                Application.Exit();
            }
        }

    }
}
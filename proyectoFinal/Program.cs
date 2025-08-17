namespace proyectoFinal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Login FAcceso = new Login();
            if(FAcceso.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string nombreUsuario = FAcceso.NombreUsuario;
                FAcceso.Close();
                Application.Run(new Form1() { NombreUsuario = nombreUsuario });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class Salir : Form
    {
        public Salir()
        {
            InitializeComponent();
        }

        private void buttonSalidaSi_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void buttonSalidaNo_Click(object sender, EventArgs e)
        {
            // Volver a la página principal
            if (this.ParentForm is Form1 formPrincipal)
            {
                formPrincipal.MostrarContenidoPrincipal();
            }
            this.Close();
        }
    }
}

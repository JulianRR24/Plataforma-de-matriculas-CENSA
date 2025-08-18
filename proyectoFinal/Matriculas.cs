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
    public partial class Matriculas : Form
    {
        public Matriculas()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            if (this.Controls.Count > 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Panel || control is GroupBox)
                    {
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            // Obtener el formulario principal y mostrar la página principal
            if (this.ParentForm is Form1 formPrincipal)
            {
                formPrincipal.MostrarContenidoPrincipal();
            }

            // Cerrar el formulario actual
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

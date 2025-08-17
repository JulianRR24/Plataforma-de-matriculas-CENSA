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
    public partial class Login : Form
    {
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;
        public string NombreUsuario { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "123")
            {
                // Guardar el nombre de usuario antes de cerrar
                NombreUsuario = textBoxUsuario.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            
            // Incrementar contador de intentos fallidos
            intentosFallidos++;
            int intentosRestantes = MAX_INTENTOS - intentosFallidos;
            
            if (intentosRestantes > 0)
            {
                MessageBox.Show($"Clave incorrecta. Te quedan {intentosRestantes} intentos.", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxContraseña.Clear();
                textBoxContraseña.Focus();
                this.DialogResult = DialogResult.None; // Evita que el formulario se cierre
            }
            else
            {
                MessageBox.Show("Has excedido el número máximo de intentos. La aplicación se cerrará.", 
                              "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmación
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", 
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                // Si el usuario elige No, no hacer nada o mantener el foco en el formulario
                this.DialogResult = DialogResult.None;
            }
        }
    }
}

namespace proyectoFinal
{
    public partial class Form1 : Form
    {
        private Panel panelContenido;
        public string? NombreUsuario { get; set; }

        public Form1()
        {
            // Primero establecer propiedades básicas del formulario
            this.BackColor = Color.White;
            this.IsMdiContainer = false; // Desactivar MDI ya que estamos usando un enfoque diferente

            // Inicializar componentes del diseñador
            InitializeComponent();

            // Crear y configurar el panel de contenido principal
            panelContenido = new Panel
            {
                Name = "panelContenido",
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            // Mostrar el contenido principal al iniciar
            this.Load += (s, e) => MostrarContenidoPrincipal();

            // Configurar el menú
            menuStrip1.BackColor = Color.White;

            // Mover controles al panel
            var controles = this.Controls.Cast<Control>().Where(c => c != menuStrip1).ToArray();

            foreach (var control in controles)
            {
                control.Parent = panelContenido;
            }

            // Asegurar que el menú esté en la parte superior
            menuStrip1.Dock = DockStyle.Top;

            // Agregar controles en el orden correcto
            this.Controls.Clear();
            this.Controls.Add(panelContenido);
            this.Controls.Add(menuStrip1);

            // Asegurar que el panel ocupe el espacio restante
            panelContenido.Dock = DockStyle.Fill;

            // Forzar actualización de la interfaz
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void MostrarContenidoPrincipal()
        {
            // Limpiar el panel de contenido
            panelContenido.Controls.Clear();

            // Agregar los controles originales al panel
            var controles = new Control[]
            {
                pictureBox1,
                label1,
                label2,
                label3,
                richTextBox1,
                richTextBox2,
                richTextBox3,
                label4,
                label5,
                label6,
                pictureBox2,
                pictureBox3,
                labelNombreUsuario
            };

            foreach (var control in controles)
            {
                control.Visible = true;
                if (control.Parent != panelContenido)
                {
                    control.Parent = panelContenido;
                }
            }
        }

        private void paginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarContenidoPrincipal();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Carreras>();
        }

        private void matriculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Matriculas>();
        }

        private void BaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<BaseDatos>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo<Salir>();
        }

        // Método genérico para abrir formularios hijos
        public void AbrirFormularioHijo<T>() where T : Form, new()
        {
            try
            {
                // Limpiar controles del panel de contenido
                panelContenido.Controls.Clear();

                // Crear el formulario
                T formulario = new T();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                // Agregar el formulario al panel de contenido
                panelContenido.Controls.Add(formulario);
                formulario.Show();

                // Manejar el cierre del formulario
                formulario.FormClosed += (s, args) =>
                {
                    panelContenido.Controls.Remove(formulario);
                    formulario.Dispose();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (panelContenido != null)
                {
                    panelContenido.Visible = true;
                    panelContenido.BringToFront();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar el label con el nombre de usuario
            if (!string.IsNullOrEmpty(NombreUsuario))
            {
                labelNombreUsuario.Text = $"Usuario: {NombreUsuario}";
            }
        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NombreUsuario))
            {
                MessageBox.Show($"Usuario actual: {NombreUsuario}", "Información de Usuario", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
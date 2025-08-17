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
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            
            // Configurar el color de fondo para paneles y groupboxes
            foreach (Control control in this.Controls)
            {
                if (control is Panel || control is GroupBox)
                {
                    control.BackColor = Color.White;
                }
            }

            // Poblar el CheckedListBox con las carreras disponibles
            checkedListBoxCarreras.Items.Add("Tecnología en Desarrollo de Software");
            checkedListBoxCarreras.Items.Add("Tecnología en Sistemas");
            checkedListBoxCarreras.Items.Add("Tecnología en Redes");
            checkedListBoxCarreras.Items.Add("Tecnología en Seguridad Informática");
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

        private void checkedListBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay algún ítem seleccionado y si el cambio fue un check
            if (checkedListBoxCarreras.CheckedItems.Count > 0 && checkedListBoxCarreras.SelectedIndex != -1)
            {
                // Obtener la carrera seleccionada
                string? carreraSeleccionada = checkedListBoxCarreras.SelectedItem?.ToString();
                
                if (!string.IsNullOrEmpty(carreraSeleccionada))
                {
                    // Preguntar al usuario si desea matricularse
                    var resultado = MessageBox.Show(
                        $"¿Desea matricularse en {carreraSeleccionada}?",
                        "Confirmar matrícula",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes && this.ParentForm is Form1 formPrincipal)
                    {
                        // Abrir el formulario de matrículas
                        formPrincipal.AbrirFormularioHijo<Matriculas>();
                        
                        // Cerrar el formulario actual después de abrir el nuevo
                        this.Close();
                    }
                    else
                    {
                        // Desmarcar el ítem si el usuario cancela
                        checkedListBoxCarreras.SetItemChecked(checkedListBoxCarreras.SelectedIndex, false);
                    }
                }
            }
        }
    }
}

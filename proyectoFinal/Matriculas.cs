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

            dataGridViewMatriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

            // AQUI: Enlazamos el DataGridView al DataTable centralizado.
            // Esto asegura que los datos persistan y que otros formularios puedan acceder a ellos.
            dataGridViewMatriculas.DataSource = DatosMatriculasManager.Instance.DatosMatriculas;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            // Obtener el formulario principal y mostrar la pgina principal
            if (this.ParentForm is Form1 formPrincipal)
            {
                formPrincipal.MostrarContenidoPrincipal();
            }

            // Cerrar el formulario actual
            this.Close();
        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // AQUI: En lugar de agregar la fila al DataGridView,
            // agregamos la fila al DataTable centralizado.
            DataRow nuevaFila = DatosMatriculasManager.Instance.DatosMatriculas.NewRow();

            nuevaFila["Cedula"] = textBoxCedula.Text;
            nuevaFila["Nombre"] = textBoxNombre.Text;
            nuevaFila["Apellido"] = textBoxApellido.Text;
            nuevaFila["Direccion"] = textBoxDireccion.Text;
            nuevaFila["Telefono"] = textBoxTelefono.Text;
            nuevaFila["Email"] = textBoxEmail.Text;
            nuevaFila["Sede"] = comboBoxSede.Text;
            nuevaFila["Programa"] = comboBoxPrograma.Text;
            nuevaFila["Horario"] = textBoxHorario.Text;
            nuevaFila["Matricula"] = textBoxMatricula.Text;
            nuevaFila["Observaciones"] = textBoxObservaciones.Text;

            // Agregamos la fila a la tabla. El DataGridView se actualizará automáticamente.
            DatosMatriculasManager.Instance.DatosMatriculas.Rows.Add(nuevaFila);

            MessageBox.Show("Matricula registrada con exito");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Para modificar, debes identificar la fila seleccionada y
            // editarla en el DataTable.
            if (dataGridViewMatriculas.SelectedRows.Count > 0)
            {
                // Obtenemos el índice de la fila seleccionada
                int indiceFila = dataGridViewMatriculas.SelectedRows[0].Index;
                DataRow filaAModificar = DatosMatriculasManager.Instance.DatosMatriculas.Rows[indiceFila];

                // Modificamos los valores
                filaAModificar["Cedula"] = textBoxCedula.Text;
                filaAModificar["Nombre"] = textBoxNombre.Text;
                filaAModificar["Apellido"] = textBoxApellido.Text;
                filaAModificar["Direccion"] = textBoxDireccion.Text;
                filaAModificar["Telefono"] = textBoxTelefono.Text;
                filaAModificar["Email"] = textBoxEmail.Text;
                filaAModificar["Sede"] = comboBoxSede.Text;
                filaAModificar["Programa"] = comboBoxPrograma.Text;
                filaAModificar["Horario"] = textBoxHorario.Text;
                filaAModificar["Matricula"] = textBoxMatricula.Text;
                filaAModificar["Observaciones"] = textBoxObservaciones.Text;

                MessageBox.Show("Registro modificado con éxito");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar.");
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            // Para borrar, debes eliminar la fila del DataTable.
            if (dataGridViewMatriculas.SelectedRows.Count > 0)
            {
                // Obtenemos el índice de la fila seleccionada
                int indiceFila = dataGridViewMatriculas.SelectedRows[0].Index;
                DatosMatriculasManager.Instance.DatosMatriculas.Rows.RemoveAt(indiceFila);

                MessageBox.Show("Registro eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Llenar los campos de texto con strings vacíos
            textBoxCedula.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            comboBoxSede.SelectedIndex = -1; // Deselecciona el item
            comboBoxPrograma.SelectedIndex = -1;
            textBoxHorario.Text = "";
            textBoxMatricula.Text = "";
            textBoxObservaciones.Text = "";
        }

        private void comboBoxSede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que haya al menos una fila seleccionada
            if (dataGridViewMatriculas.SelectedRows.Count == 0) return;

            try
            {
                // Obtener la primera fila seleccionada
                DataGridViewRow row = dataGridViewMatriculas.SelectedRows[0];

                // Actualizar los controles
                textBoxCedula.Text = row.Cells[0]?.Value?.ToString() ?? "";
                textBoxNombre.Text = row.Cells[1]?.Value?.ToString() ?? "";
                textBoxApellido.Text = row.Cells[2]?.Value?.ToString() ?? "";
                textBoxDireccion.Text = row.Cells[3]?.Value?.ToString() ?? "";
                textBoxTelefono.Text = row.Cells[4]?.Value?.ToString() ?? "";
                textBoxEmail.Text = row.Cells[5]?.Value?.ToString() ?? "";
                comboBoxSede.Text = row.Cells[6]?.Value?.ToString() ?? "";
                comboBoxPrograma.Text = row.Cells[7]?.Value?.ToString() ?? "";
                textBoxHorario.Text = row.Cells[8]?.Value?.ToString() ?? "";
                textBoxMatricula.Text = row.Cells[9]?.Value?.ToString() ?? "";
                textBoxObservaciones.Text = row.Cells[10]?.Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
    }
}
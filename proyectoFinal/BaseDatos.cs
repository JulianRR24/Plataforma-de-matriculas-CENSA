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
    public partial class BaseDatos : Form
    {
        public BaseDatos()
        {
            InitializeComponent();
            // Enlaza el DataGridView al mismo DataTable centralizado
            dataGridViewBaseDatos.DataSource = DatosMatriculasManager.Instance.DatosMatriculas;

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

        private void dataGridViewBaseDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExportarDatos_Click(object sender, EventArgs e)
        {
            // Usamos un SaveFileDialog para que el usuario elija dónde guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"; // Filtra para que solo se muestren archivos CSV
            saveFileDialog.FileName = "DatosMatriculas.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Abrimos un escritor de archivos para guardar el contenido
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir los encabezados de las columnas
                        for (int i = 0; i < dataGridViewBaseDatos.Columns.Count; i++)
                        {
                            sw.Write(dataGridViewBaseDatos.Columns[i].HeaderText);
                            if (i < dataGridViewBaseDatos.Columns.Count - 1)
                            {
                                sw.Write(","); // Usa una coma para separar los encabezados
                            }
                        }
                        sw.WriteLine(); // Agrega un salto de línea para empezar con los datos

                        // Escribir los datos de cada fila
                        foreach (DataGridViewRow row in dataGridViewBaseDatos.Rows)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                // Aseguramos que el valor no sea nulo antes de escribirlo
                                sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                if (i < row.Cells.Count - 1)
                                {
                                    sw.Write(",");
                                }
                            }
                            sw.WriteLine(); // Salto de línea para la siguiente fila
                        }
                    }
                    MessageBox.Show("Los datos se han exportado correctamente a un archivo CSV. Puedes abrirlo con Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

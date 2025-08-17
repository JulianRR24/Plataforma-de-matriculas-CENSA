namespace proyectoFinal
{
    partial class Carreras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            buttonCerrar = new Button();
            checkedListBoxCarreras = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logositio;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Matrículas_Abiertas_Slide_21_05_2025;
            pictureBox2.Location = new Point(745, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2092, 981);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(331, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 54);
            label1.TabIndex = 4;
            label1.Text = "Carreras";
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCerrar.ForeColor = Color.Green;
            buttonCerrar.Location = new Point(12, 921);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(109, 48);
            buttonCerrar.TabIndex = 5;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // checkedListBoxCarreras
            // 
            checkedListBoxCarreras.CheckOnClick = true;
            checkedListBoxCarreras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBoxCarreras.FormattingEnabled = true;
            checkedListBoxCarreras.Items.AddRange(new object[] { "Tecnico Laboral en Asistente de Mercadeo", "Tecnico Laboral en Asistente en Logistica en Centros de Distribucion", "Tecnico Laboral en Asesor de Call Center y Servicio al Cliente", "Tecnico Laboral en Agente Turistico", "Tecnico Laboral en Auxiliar en enfermeria", "Tecnico Laboral en Auxiliar en Salud Oral", "Tecnico Laboral en Auxiliar en Servicios Farmaceuticos", "Tecnico Laboral en Auxiliar en Salud Publica", "Tecnico Laboral en Auxiliar Administrativo en Salud", "Tecnico Laboral en Atencion Integral al Adulto Mayor", "Tecnico Laboral en Auxiliar en Tanatopraxia", "Tecnico Laboral en Procedimientos Administrativos", "Tecnico Laboral en Procedimientos Contables", "Tecnico Laboral en Auxiliar de Recursos Humanos", "Tecnico Laboral en Auxiliar de Costos y Presupuestos", "Tecnico Laboral en Auxiliar en Secretariado Gerencial", "Tecnico Laboral en Secretariado Contable y Financiero", "Tecnico Laboral en Secretariado Bilingue Nivel B1", "Tecnico Laboral en Auxiliar de Archivo", "Tecnico Laboral en Auxiliar de Banca y Finanzas", "Tecnico Laboral en Auxiliar de Comercio Exterior", "Tecnico Laboral en Asistente Legal y Juridico", "Tecnico Laboral en Auxiliar Administrativo en Documentacion Catastral", "Tecnico Laboral en Auxiliar en Diseno Grafico Digital", "Tecnico Laboral en Ensamble y Mantenimiento de Equipos de Computo", "Tecnico Laboral en Asistente en Analisis y Desarrollo de Software", "Tecnico Laboral en Asistente en Electronica Digital y Telecomunicaciones", "Tecnico Laboral en Instalador de Redes y Telecomunicaciones", "Tecnico Laboral en Auxiliar de Desarrollo Web", "Tecnico Laboral en Auxiliar de Desarrollo de Aplicaciones Moviles", "Programa de Ingles", "Curso de Ingles A1", "Curso de Ingles A2", "Curso de Ingles B1", "Curso de Ingles B2", "Curso de Ingles C1", "Cursos Frances hasta Nivel B2", "Tecnico Laboral en Atencion Integral a la Primera Infancia", "Tecnico Laboral como Instructor en Entrenamiento Deportivo y Recreacion", "Tecnico Laboral en Asesoria de Imagen", "Tecnico Laboral en Barberia", "Tecnico Laboral en Cuidado Estetico de Manos y Pies", "Tecnico Laboral en auxiliar de Personal y Riesgo Laboral", "Tecnico Laboral en Auxiliar de Clinica Veterinaria", "Tecnico Laboral en Asistente en Mecanica de Motos", "Tecnico Laboral en Auxiliar de Cocina", "Tecnico Laboral en Auxiliar de Panaderia y Pasteleria", "Tecnico Laboral en Operador de Eventos", "Tecnico Laboral en Bartender" });
            checkedListBoxCarreras.Location = new Point(66, 118);
            checkedListBoxCarreras.Name = "checkedListBoxCarreras";
            checkedListBoxCarreras.Size = new Size(601, 772);
            checkedListBoxCarreras.TabIndex = 7;
            checkedListBoxCarreras.SelectedIndexChanged += checkedListBoxCarreras_SelectedIndexChanged;
            // 
            // Carreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 981);
            Controls.Add(checkedListBoxCarreras);
            Controls.Add(buttonCerrar);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Carreras";
            Text = "Carreras";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button buttonCerrar;
        private CheckedListBox checkedListBoxCarreras;
    }
}
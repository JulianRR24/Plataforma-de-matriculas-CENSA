namespace proyectoFinal
{
    partial class Matriculas
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
            groupBox1 = new GroupBox();
            buttonLimpiar = new Button();
            buttonBorrar = new Button();
            buttonModificar = new Button();
            buttonRegistrar = new Button();
            pictureBox1 = new PictureBox();
            buttonCerrar = new Button();
            label1 = new Label();
            textBoxCedula = new TextBox();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxApellido = new TextBox();
            label3 = new Label();
            textBoxDireccion = new TextBox();
            label4 = new Label();
            textBoxTelefono = new TextBox();
            label5 = new Label();
            textBoxEmail = new TextBox();
            label6 = new Label();
            comboBoxSede = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxPrograma = new ComboBox();
            textBoxHorario = new TextBox();
            label9 = new Label();
            textBoxMatricula = new TextBox();
            label10 = new Label();
            textBoxObservaciones = new TextBox();
            label11 = new Label();
            dataGridViewMatriculas = new DataGridView();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatriculas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLimpiar);
            groupBox1.Controls.Add(buttonBorrar);
            groupBox1.Controls.Add(buttonModificar);
            groupBox1.Controls.Add(buttonRegistrar);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(43, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Botones";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(18, 296);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(153, 45);
            buttonLimpiar.TabIndex = 3;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(18, 213);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(153, 45);
            buttonBorrar.TabIndex = 2;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(18, 136);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(153, 45);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(18, 54);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(153, 45);
            buttonRegistrar.TabIndex = 0;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logositio;
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCerrar.ForeColor = Color.Green;
            buttonCerrar.Location = new Point(24, 912);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(109, 48);
            buttonCerrar.TabIndex = 6;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 129);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 7;
            label1.Text = "Cedula";
            // 
            // textBoxCedula
            // 
            textBoxCedula.Location = new Point(258, 134);
            textBoxCedula.Name = "textBoxCedula";
            textBoxCedula.Size = new Size(183, 23);
            textBoxCedula.TabIndex = 8;
            textBoxCedula.TextChanged += textBoxCedula_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(678, 134);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(183, 23);
            textBoxNombre.TabIndex = 10;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(578, 129);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(1093, 136);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(183, 23);
            textBoxApellido.TabIndex = 12;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(991, 129);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(585, 217);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(183, 23);
            textBoxDireccion.TabIndex = 14;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(474, 210);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 13;
            label4.Text = "Dirección";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(1468, 136);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(183, 23);
            textBoxTelefono.TabIndex = 16;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1364, 129);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 15;
            label5.Text = "Telefono";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(258, 217);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(183, 23);
            textBoxEmail.TabIndex = 18;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 210);
            label6.Name = "label6";
            label6.Size = new Size(74, 30);
            label6.TabIndex = 17;
            label6.Text = "E-mail";
            // 
            // comboBoxSede
            // 
            comboBoxSede.FormattingEnabled = true;
            comboBoxSede.Items.AddRange(new object[] { "Andes", "Apartadó", "Barbosa", "Bello", "Bogotá", "Caldas Antioquia", "Cañasgordas", "Cartago", "Caucasia", "Chinchiná", "Concordia", "Frontino", "Itagüí", "La Dorada", "Manizales", "Medellín", "Montería", "Puerto Triunfo", "Rionegro", "Santa Fé De Antioquia", "Segovia", "Támesis", "Yarumal" });
            comboBoxSede.Location = new Point(878, 216);
            comboBoxSede.Name = "comboBoxSede";
            comboBoxSede.Size = new Size(183, 23);
            comboBoxSede.TabIndex = 19;
            comboBoxSede.SelectedIndexChanged += comboBoxSede_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(812, 210);
            label7.Name = "label7";
            label7.Size = new Size(60, 30);
            label7.TabIndex = 20;
            label7.Text = "Sede";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1093, 210);
            label8.Name = "label8";
            label8.Size = new Size(109, 30);
            label8.TabIndex = 22;
            label8.Text = "Programa";
            // 
            // comboBoxPrograma
            // 
            comboBoxPrograma.FormattingEnabled = true;
            comboBoxPrograma.Items.AddRange(new object[] { "Tecnico Laboral en Asistente de Mercadeo", "Tecnico Laboral en Asistente en Logistica en Centros de Distribucion", "Tecnico Laboral en Asesor de Call Center y Servicio al Cliente", "Tecnico Laboral en Agente Turistico", "Tecnico Laboral en Auxiliar en enfermeria", "Tecnico Laboral en Auxiliar en Salud Oral", "Tecnico Laboral en Auxiliar en Servicios Farmaceuticos", "Tecnico Laboral en Auxiliar en Salud Publica", "Tecnico Laboral en Auxiliar Administrativo en Salud", "Tecnico Laboral en Atencion Integral al Adulto Mayor", "Tecnico Laboral en Auxiliar en Tanatopraxia", "Tecnico Laboral en Procedimientos Administrativos", "Tecnico Laboral en Procedimientos Contables", "Tecnico Laboral en Auxiliar de Recursos Humanos", "Tecnico Laboral en Auxiliar de Costos y Presupuestos", "Tecnico Laboral en Auxiliar en Secretariado Gerencial", "Tecnico Laboral en Secretariado Contable y Financiero", "Tecnico Laboral en Secretariado Bilingue Nivel B1", "Tecnico Laboral en Auxiliar de Archivo", "Tecnico Laboral en Auxiliar de Banca y Finanzas", "Tecnico Laboral en Auxiliar de Comercio Exterior", "Tecnico Laboral en Asistente Legal y Juridico", "Tecnico Laboral en Auxiliar Administrativo en Documentacion Catastral", "Tecnico Laboral en Auxiliar en Diseno Grafico Digital", "Tecnico Laboral en Ensamble y Mantenimiento de Equipos de Computo", "Tecnico Laboral en Asistente en Analisis y Desarrollo de Software", "Tecnico Laboral en Asistente en Electronica Digital y Telecomunicaciones", "Tecnico Laboral en Instalador de Redes y Telecomunicaciones", "Tecnico Laboral en Auxiliar de Desarrollo Web", "Tecnico Laboral en Auxiliar de Desarrollo de Aplicaciones Moviles", "Programa de Ingles", "Curso de Ingles A1", "Curso de Ingles A2", "Curso de Ingles B1", "Curso de Ingles B2", "Curso de Ingles C1", "Cursos Frances hasta Nivel B2", "Tecnico Laboral en Atencion Integral a la Primera Infancia", "Tecnico Laboral como Instructor en Entrenamiento Deportivo y Recreacion", "Tecnico Laboral en Asesoria de Imagen", "Tecnico Laboral en Barberia", "Tecnico Laboral en Cuidado Estetico de Manos y Pies", "Tecnico Laboral en auxiliar de Personal y Riesgo Laboral", "Tecnico Laboral en Auxiliar de Clinica Veterinaria", "Tecnico Laboral en Asistente en Mecanica de Motos", "Tecnico Laboral en Auxiliar de Cocina", "Tecnico Laboral en Auxiliar de Panaderia y Pasteleria", "Tecnico Laboral en Operador de Eventos", "Tecnico Laboral en Bartender" });
            comboBoxPrograma.Location = new Point(1208, 216);
            comboBoxPrograma.Name = "comboBoxPrograma";
            comboBoxPrograma.Size = new Size(443, 23);
            comboBoxPrograma.TabIndex = 21;
            comboBoxPrograma.SelectedIndexChanged += comboBoxPrograma_SelectedIndexChanged;
            // 
            // textBoxHorario
            // 
            textBoxHorario.Location = new Point(258, 298);
            textBoxHorario.Name = "textBoxHorario";
            textBoxHorario.Size = new Size(183, 23);
            textBoxHorario.TabIndex = 24;
            textBoxHorario.TextChanged += textBoxHorario_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(164, 289);
            label9.Name = "label9";
            label9.Size = new Size(88, 30);
            label9.TabIndex = 23;
            label9.Text = "Horario";
            // 
            // textBoxMatricula
            // 
            textBoxMatricula.Location = new Point(678, 302);
            textBoxMatricula.Name = "textBoxMatricula";
            textBoxMatricula.Size = new Size(183, 23);
            textBoxMatricula.TabIndex = 26;
            textBoxMatricula.TextChanged += textBoxMatricula_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(510, 293);
            label10.Name = "label10";
            label10.Size = new Size(162, 30);
            label10.TabIndex = 25;
            label10.Text = "Valor Matricula";
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.Location = new Point(1093, 302);
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(558, 23);
            textBoxObservaciones.TabIndex = 28;
            textBoxObservaciones.TextChanged += textBoxObservaciones_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(932, 293);
            label11.Name = "label11";
            label11.Size = new Size(155, 30);
            label11.TabIndex = 27;
            label11.Text = "Observaciones";
            // 
            // dataGridViewMatriculas
            // 
            dataGridViewMatriculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatriculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatriculas.Location = new Point(306, 379);
            dataGridViewMatriculas.Name = "dataGridViewMatriculas";
            dataGridViewMatriculas.Size = new Size(1487, 506);
            dataGridViewMatriculas.TabIndex = 29;
            dataGridViewMatriculas.CellContentClick += dataGridViewMatriculas_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(831, 24);
            label12.Name = "label12";
            label12.Size = new Size(202, 54);
            label12.TabIndex = 30;
            label12.Text = "Matricula";
            // 
            // Matriculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 981);
            Controls.Add(label12);
            Controls.Add(dataGridViewMatriculas);
            Controls.Add(textBoxObservaciones);
            Controls.Add(label11);
            Controls.Add(textBoxMatricula);
            Controls.Add(label10);
            Controls.Add(textBoxHorario);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxPrograma);
            Controls.Add(label7);
            Controls.Add(comboBoxSede);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(textBoxTelefono);
            Controls.Add(label5);
            Controls.Add(textBoxDireccion);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxCedula);
            Controls.Add(label1);
            Controls.Add(buttonCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "Matriculas";
            Text = "Matriculas";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatriculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonRegistrar;
        private PictureBox pictureBox1;
        private Button buttonLimpiar;
        private Button buttonBorrar;
        private Button buttonModificar;
        private Button buttonCerrar;
        private Label label1;
        private TextBox textBoxCedula;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxApellido;
        private Label label3;
        private TextBox textBoxDireccion;
        private Label label4;
        private TextBox textBoxTelefono;
        private Label label5;
        private TextBox textBoxEmail;
        private Label label6;
        private ComboBox comboBoxSede;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxPrograma;
        private TextBox textBoxHorario;
        private Label label9;
        private TextBox textBoxMatricula;
        private Label label10;
        private TextBox textBoxObservaciones;
        private Label label11;
        private DataGridView dataGridViewMatriculas;
        private Label label12;
    }
}
namespace proyectoFinal
{
    partial class BaseDatos
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewBaseDatos = new DataGridView();
            buttonExportarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(546, 32);
            label1.Name = "label1";
            label1.Size = new Size(816, 54);
            label1.TabIndex = 0;
            label1.Text = "Informe General Base de Datos Matriculas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logositio;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewBaseDatos
            // 
            dataGridViewBaseDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBaseDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBaseDatos.Location = new Point(22, 151);
            dataGridViewBaseDatos.Name = "dataGridViewBaseDatos";
            dataGridViewBaseDatos.Size = new Size(1848, 709);
            dataGridViewBaseDatos.TabIndex = 30;
            dataGridViewBaseDatos.CellContentClick += dataGridViewBaseDatos_CellContentClick;
            // 
            // buttonExportarDatos
            // 
            buttonExportarDatos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportarDatos.ForeColor = Color.Green;
            buttonExportarDatos.Location = new Point(560, 898);
            buttonExportarDatos.Name = "buttonExportarDatos";
            buttonExportarDatos.Size = new Size(817, 48);
            buttonExportarDatos.TabIndex = 31;
            buttonExportarDatos.Text = "Exporta los datos";
            buttonExportarDatos.UseVisualStyleBackColor = true;
            buttonExportarDatos.Click += buttonExportarDatos_Click;
            // 
            // BaseDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 981);
            Controls.Add(buttonExportarDatos);
            Controls.Add(dataGridViewBaseDatos);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "BaseDatos";
            Text = "BaseDatos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBaseDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewBaseDatos;
        private Button buttonExportarDatos;
    }
}
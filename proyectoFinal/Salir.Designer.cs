namespace proyectoFinal
{
    partial class Salir
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
            label2 = new Label();
            buttonSalidaSi = new Button();
            buttonSalidaNo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logositio;
            pictureBox1.Location = new Point(11, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bannerFinal;
            pictureBox2.Location = new Point(0, 424);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1904, 558);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 47);
            label1.Name = "label1";
            label1.Size = new Size(1001, 45);
            label1.TabIndex = 5;
            label1.Text = "¡Gracias por usar la aplicación! Esperamos verte de nuevo pronto.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(739, 204);
            label2.Name = "label2";
            label2.Size = new Size(333, 30);
            label2.TabIndex = 6;
            label2.Text = "¿Estás seguro de que quieres salir?";
            // 
            // buttonSalidaSi
            // 
            buttonSalidaSi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalidaSi.Location = new Point(799, 265);
            buttonSalidaSi.Name = "buttonSalidaSi";
            buttonSalidaSi.Size = new Size(83, 45);
            buttonSalidaSi.TabIndex = 7;
            buttonSalidaSi.Text = "SI";
            buttonSalidaSi.UseVisualStyleBackColor = true;
            buttonSalidaSi.Click += buttonSalidaSi_Click;
            // 
            // buttonSalidaNo
            // 
            buttonSalidaNo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalidaNo.Location = new Point(914, 265);
            buttonSalidaNo.Name = "buttonSalidaNo";
            buttonSalidaNo.Size = new Size(83, 45);
            buttonSalidaNo.TabIndex = 8;
            buttonSalidaNo.Text = "NO";
            buttonSalidaNo.UseVisualStyleBackColor = true;
            buttonSalidaNo.Click += buttonSalidaNo_Click;
            // 
            // Salir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 981);
            Controls.Add(buttonSalidaNo);
            Controls.Add(buttonSalidaSi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Salir";
            Text = "Salir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button buttonSalidaSi;
        private Button buttonSalidaNo;
    }
}
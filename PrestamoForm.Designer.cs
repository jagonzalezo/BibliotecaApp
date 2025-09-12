namespace BibliotecaApp
{
    partial class PrestamoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamoForm));
            cmbUsuario = new ComboBox();
            cmbLibro = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtpPrestamo = new DateTimePicker();
            dtpDevolucion = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            chkDevuelto = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(163, 99);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(173, 23);
            cmbUsuario.TabIndex = 0;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(163, 155);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(173, 23);
            cmbLibro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 104);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 163);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Libro";
            // 
            // dtpPrestamo
            // 
            dtpPrestamo.Location = new Point(510, 99);
            dtpPrestamo.Name = "dtpPrestamo";
            dtpPrestamo.Size = new Size(200, 23);
            dtpPrestamo.TabIndex = 4;
            // 
            // dtpDevolucion
            // 
            dtpDevolucion.Location = new Point(510, 155);
            dtpDevolucion.Name = "dtpDevolucion";
            dtpDevolucion.Size = new Size(200, 23);
            dtpDevolucion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 104);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha Prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 161);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha Devolucion";
            // 
            // chkDevuelto
            // 
            chkDevuelto.AutoSize = true;
            chkDevuelto.Location = new Point(512, 214);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(73, 19);
            chkDevuelto.TabIndex = 8;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(261, 307);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Location = new Point(512, 307);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Highlight;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(245, 25);
            label5.Name = "label5";
            label5.Size = new Size(211, 22);
            label5.TabIndex = 12;
            label5.Text = "Gestion de Prestamos";
            // 
            // PrestamoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(chkDevuelto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpDevolucion);
            Controls.Add(dtpPrestamo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbLibro);
            Controls.Add(cmbUsuario);
            Name = "PrestamoForm";
            Text = "PrestamoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuario;
        private ComboBox cmbLibro;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpPrestamo;
        private DateTimePicker dtpDevolucion;
        private Label label3;
        private Label label4;
        private CheckBox chkDevuelto;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
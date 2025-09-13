namespace BibliotecaApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            AGlibro = new Button();
            btnEliminar = new Button();
            AGuser = new Button();
            ELeUser = new Button();
            AGprestamo = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            GenReport = new Button();
            ExitApp = new Button();
            ELePrestamo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(424, 25);
            label1.Name = "label1";
            label1.Size = new Size(226, 24);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 106);
            label2.Name = "label2";
            label2.Size = new Size(144, 17);
            label2.TabIndex = 1;
            label2.Text = "Administrar Libros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(468, 106);
            label3.Name = "label3";
            label3.Size = new Size(163, 17);
            label3.TabIndex = 2;
            label3.Text = "Administrar Usuarios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(835, 106);
            label4.Name = "label4";
            label4.Size = new Size(188, 17);
            label4.TabIndex = 3;
            label4.Text = "Prestamos/Devoluciones";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 216);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(381, 138);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(341, 216);
            dataGridView2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(748, 138);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(348, 216);
            dataGridView3.TabIndex = 6;
            // 
            // AGlibro
            // 
            AGlibro.Location = new Point(60, 377);
            AGlibro.Name = "AGlibro";
            AGlibro.Size = new Size(91, 23);
            AGlibro.TabIndex = 7;
            AGlibro.Text = "Agregar Libro";
            AGlibro.UseVisualStyleBackColor = true;
            AGlibro.Click += AGlibro_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(157, 377);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // AGuser
            // 
            AGuser.Location = new Point(468, 377);
            AGuser.Name = "AGuser";
            AGuser.Size = new Size(101, 23);
            AGuser.TabIndex = 10;
            AGuser.Text = "Agregar Usuario";
            AGuser.UseVisualStyleBackColor = true;
            AGuser.Click += AGuser_Click;
            // 
            // ELeUser
            // 
            ELeUser.Location = new Point(577, 377);
            ELeUser.Name = "ELeUser";
            ELeUser.Size = new Size(109, 23);
            ELeUser.TabIndex = 11;
            ELeUser.Text = "Eliminar Usuario";
            ELeUser.UseVisualStyleBackColor = true;
            ELeUser.Click += ELeUser_Click;
            // 
            // AGprestamo
            // 
            AGprestamo.Location = new Point(748, 377);
            AGprestamo.Name = "AGprestamo";
            AGprestamo.Size = new Size(124, 23);
            AGprestamo.TabIndex = 13;
            AGprestamo.Text = "Realizar Prestamo";
            AGprestamo.UseVisualStyleBackColor = true;
            AGprestamo.Click += AGprestamo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(408, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(768, 81);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 357);
            label5.Name = "label5";
            label5.Size = new Size(278, 15);
            label5.TabIndex = 18;
            label5.Text = "Seleccione Linea y Doble Click para modificar datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 357);
            label6.Name = "label6";
            label6.Size = new Size(278, 15);
            label6.TabIndex = 19;
            label6.Text = "Seleccione Linea y Doble Click para modificar datos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(69, 426);
            label7.Name = "label7";
            label7.Size = new Size(82, 18);
            label7.TabIndex = 20;
            label7.Text = "Reportes";
            // 
            // GenReport
            // 
            GenReport.Location = new Point(69, 447);
            GenReport.Name = "GenReport";
            GenReport.Size = new Size(111, 23);
            GenReport.TabIndex = 21;
            GenReport.Text = "Generar Reporte";
            GenReport.UseVisualStyleBackColor = true;
            GenReport.Click += GenReport_Click;
            // 
            // ExitApp
            // 
            ExitApp.BackColor = Color.LightCoral;
            ExitApp.Cursor = Cursors.Hand;
            ExitApp.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitApp.Location = new Point(980, 454);
            ExitApp.Name = "ExitApp";
            ExitApp.Size = new Size(93, 37);
            ExitApp.TabIndex = 22;
            ExitApp.Text = "Salir de la App";
            ExitApp.UseVisualStyleBackColor = false;
            ExitApp.Click += ExitApp_Click;
            // 
            // ELePrestamo
            // 
            ELePrestamo.Location = new Point(933, 377);
            ELePrestamo.Name = "ELePrestamo";
            ELePrestamo.Size = new Size(163, 23);
            ELePrestamo.TabIndex = 14;
            ELePrestamo.Text = "Eliminar Registro Prestamo";
            ELePrestamo.UseVisualStyleBackColor = true;
            ELePrestamo.Click += ELePrestamo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1120, 506);
            Controls.Add(ExitApp);
            Controls.Add(GenReport);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ELePrestamo);
            Controls.Add(AGprestamo);
            Controls.Add(ELeUser);
            Controls.Add(AGuser);
            Controls.Add(btnEliminar);
            Controls.Add(AGlibro);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button AGlibro;
        private Button btnEliminar;
        private Button AGuser;
        private Button ELeUser;
        private Button AGprestamo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button GenReport;
        private Button ExitApp;
        private Button ELePrestamo;
    }
}
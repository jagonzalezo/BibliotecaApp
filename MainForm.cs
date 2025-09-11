using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaApp.Models;

namespace BibliotecaApp
{
    public partial class MainForm : Form
    {
        private List<Libro> libros = new List<Libro>();
        public MainForm()
        {
            InitializeComponent();

            // Configurar DataGridView
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = libros;
        }

        private void AGlibro_Click(object sender, EventArgs e)
        {
            AddLibro formAdd = new AddLibro();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                //Agregar el nuevo libro a la lista y actualizar el DataGridView
                libros.Add(formAdd.NuevoLibro);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = libros;

            }

        }
    }
}

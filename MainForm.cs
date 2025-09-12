using BibliotecaApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BibliotecaApp
{
    public partial class MainForm : Form
    {
        private List<Libro> libros = new List<Libro>();
        private string rutaArchivo = "libros.json";
        public MainForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            CargarLibros();
            RefrescarGrid();
        }

        private void CargarLibros()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                libros = JsonConvert.DeserializeObject<List<Libro>>(json) ?? new List<Libro>();
            }
        }

        private void GuardarLibros()
        {
            string json = JsonConvert.SerializeObject(libros, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        private void RefrescarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = libros;
        }

        private void AGlibro_Click(object sender, EventArgs e)
        {
            using (var formAdd = new AddLibro())

            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {

                    libros.Add(formAdd.NuevoLibro);
                    RefrescarGrid();
                    GuardarLibros(); // se guardan los cambios
                }
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un libro válido para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var libroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Libro;
            if (libroSeleccionado == null) return;

            var confirm = MessageBox.Show(
                $"¿Está seguro de eliminar \"{libroSeleccionado.Nombre}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                libros.Remove(libroSeleccionado);
                RefrescarGrid();
                GuardarLibros();
            }
        }

        // Evento para guardar al terminar de editar una celda en la tabla
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarLibros();

        }

    }
}

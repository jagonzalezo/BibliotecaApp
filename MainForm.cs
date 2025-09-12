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
        //Memoria para libros
        private List<Libro> libros = new List<Libro>();
        private string rutaArchivo = "libros.json";

        //Memoria para usuarios
        private List<Usuario> usuarios = new List<Usuario>();
        private string rutaArchivoUsuarios = "usuarios.json";
        public MainForm()
        {
            InitializeComponent();

            // Configuración del DataGridView para libros
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;

            // Configuración del DataGridView para usuarios
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;

            CargarLibros();
            CargarUsuarios();
            RefrescarGridLibros();
            RefrescarGridUsuarios();


        }
        // Parte de libros
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

        private void RefrescarGridLibros()
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
                    RefrescarGridLibros();
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
                RefrescarGridLibros();
                GuardarLibros();
            }
        }

        // Evento para guardar al terminar de editar una celda en la tabla
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarLibros();

        }

        // Parte de usuarios

        private void CargarUsuarios()
        {
            if (File.Exists(rutaArchivoUsuarios))
            {
                string json = File.ReadAllText(rutaArchivoUsuarios);
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }
        }
        private void GuardarUsuarios()
        {
            string json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText(rutaArchivoUsuarios, json);
        }
        private void RefrescarGridUsuarios()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = usuarios;
        }
        private void AGuser_Click(object sender, EventArgs e)
        {
            using (var formAdd = new AddUsuario())
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    usuarios.Add(formAdd.NuevoUsuario);
                    RefrescarGridUsuarios();
                    GuardarUsuarios(); // se guardan los cambios
                }
            }
        }
        private void ELeUser_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un usuario válido para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            var usuarioSeleccionado = dataGridView2.CurrentRow.DataBoundItem as Usuario;
            if (usuarioSeleccionado == null) return;
            var confirm = MessageBox.Show(
                $"¿Está seguro de eliminar \"{usuarioSeleccionado.Nombre}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                usuarios.Remove(usuarioSeleccionado);
                RefrescarGridUsuarios();
                GuardarUsuarios();
            }
        }
        // Evento para guardar al terminar de editar una celda en la tabla
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarUsuarios();
        }

              
    }
}


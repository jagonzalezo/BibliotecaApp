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

        //Memoria para prestamos
        private List<Prestamo> prestamos = new List<Prestamo>();
        private string rutaArchivoPrestamos = "prestamos.json";
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

            // Configuración del DataGridView para prestamos
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.CellEndEdit += dataGridView3_CellEndEdit;

            CargarLibros();
            CargarUsuarios();
            CargarPrestamos();
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
                    GuardarLibros();
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
                    GuardarUsuarios();
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
        // Parte de prestamos
        private void CargarPrestamos()
        {
            if (File.Exists(rutaArchivoPrestamos))
            {
                string json = File.ReadAllText(rutaArchivoPrestamos);
                prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(json) ?? new List<Prestamo>();
            }
        }
        private void GuardarPrestamos()
        {
            string json = JsonConvert.SerializeObject(prestamos, Formatting.Indented);
            File.WriteAllText(rutaArchivoPrestamos, json);
        }
        private void RefrescarGridPrestamos()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = prestamos;
        }

        private void AGprestamo_Click(object sender, EventArgs e)
        {
            using (var formAdd = new PrestamoForm(
                usuarios.Select(u => u.Nombre).ToArray(),
                libros.Select(l => l.Nombre).ToArray()))
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    //Buscar libro seleccionado en la lista.
                    var libroPrestado = libros.FirstOrDefault(l => l.Nombre == formAdd.NuevoPrestamo.Libro);
                    if (libroPrestado != null)
                    {

                        MessageBox.Show("El libro seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    if (libroPrestado.CantidadDisponible <= 0)
                    {
                        MessageBox.Show("No hay copias disponibles de este libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    libroPrestado.CantidadDisponible--;

                    prestamos.Add(formAdd.NuevoPrestamo);
                    RefrescarGridPrestamos();
                    RefrescarGridLibros();
                    GuardarLibros();
                    GuardarPrestamos();
                }
            }

        }

        private void ELePrestamo_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null || dataGridView3.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un préstamo válido para eliminar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            var prestamoSeleccionado = dataGridView3.CurrentRow.DataBoundItem as Prestamo;
            if (prestamoSeleccionado == null) return;
            var confirm = MessageBox.Show(
                $"¿Está seguro de eliminar el préstamo de \"{prestamoSeleccionado.Libro}\" a \"{prestamoSeleccionado.Usuario}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.Yes)
            {
                prestamos.Remove(prestamoSeleccionado);
                // Devolver el libro si no ha sido devuelto
                if (!prestamoSeleccionado.Devuelto)
                {
                    var libroDevuelto = libros.FirstOrDefault(l => l.Nombre == prestamoSeleccionado.Libro);
                    if (libroDevuelto != null)
                    {
                        libroDevuelto.CantidadDisponible++;
                        RefrescarGridLibros();
                        GuardarLibros();
                    }
                }
                RefrescarGridPrestamos();
                GuardarPrestamos();
            }


        }
        // Evento para guardar al terminar de editar una celda en la tabla
        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarPrestamos();
        }
    }
}


using System;
using System.Windows.Forms;
using BibliotecaApp.Models;

namespace BibliotecaApp
{
    public partial class AddLibro : Form
    {
        public Libro NuevoLibro { get; private set; }
        public AddLibro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoLibro = new Libro
                {
                    Nombre = txtNombre.Text,
                    Autor = txtAutor.Text,
                    ISBN = txtISBN.Text,
                    CantidadDisponible = int.Parse(txtCantidad.Text)
                };
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Verifique los datos ingresados.");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

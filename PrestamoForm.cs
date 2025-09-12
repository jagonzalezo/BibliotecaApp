using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class PrestamoForm : Form
    {
        public Prestamo NuevoPrestamo { get; private set; }
        public PrestamoForm(string[] usuarios, string[] libros)

        //public PrestamoForm()
        {
            InitializeComponent();

            cmbUsuario.Items.AddRange(usuarios);
            cmbLibro.Items.AddRange(libros);
            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now.AddDays(7);
            dtpDevolucion.Enabled = false;
            chkDevuelto.CheckedChanged += (s, e) => dtpDevolucion.Enabled = chkDevuelto.Checked;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex < 0 || cmbLibro.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario y un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NuevoPrestamo = new Prestamo
            {
                Usuario = cmbUsuario.SelectedItem.ToString(),
                Libro = cmbLibro.SelectedItem.ToString(),
                FechaPrestamo = dtpPrestamo.Value,
                Devuelto = chkDevuelto.Checked,
                FechaDevolucion = chkDevuelto.Checked ? dtpDevolucion.Value : (DateTime?)null
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

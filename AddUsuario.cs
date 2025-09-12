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
    public partial class AddUsuario : Form
    {
        public Usuario NuevoUsuario { get; private set; }
        public AddUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoUsuario = new Usuario
                {
                    Nombre = textNombre.Text,
                    Apellido = textApellido.Text,
                    Carnet = textCarnet.Text
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

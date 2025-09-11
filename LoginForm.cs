using System.Drawing;
namespace BibliotecaApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = this.textBox1.Text;
            string contraseña = this.textBox2.Text;
            if ((textBox1.Text == "admin" && textBox2.Text == "password") ||
                (textBox1.Text == "user" && textBox2.Text == "1234") ||
                (textBox1.Text == "guest" && textBox2.Text == "guest"))
            {
                //MessageBox.Show("Login correcto");
                
                MessageBox.Show("Inicio de sesión correcto", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Login exitoso pasa al MainForm de gestion de Biblioteca
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                //MessageBox.Show("Error login");
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}

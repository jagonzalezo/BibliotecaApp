namespace BibliotecaApp
{
     public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e) 
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            if ((textBox1.Text == "admin" && textBox2.Text == "password") ||
                (textBox1.Text == "user" && textBox2.Text == "1234") ||
                (textBox1.Text == "guest" && textBox2.Text == "guest"))
            {
               MessageBox.Show("Login correcto");  
            }
            else
            {
                MessageBox.Show("Error login");
            }
        }
     }
}

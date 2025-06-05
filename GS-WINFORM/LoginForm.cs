using System;
using System.Windows.Forms;

namespace GS_WINFORM
{
    public partial class LoginForm : Form
    {

        // Inicializa os componentes da tela de login 
        public LoginForm()
        {
            InitializeComponent();
        }


        // Campo para futuras implementacoes com Loads e Textboxes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Verifica se o usuario e admin e a senha 1234 para abir a main page
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234") // login fixo
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
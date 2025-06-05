using System;
using System.Windows.Forms;

namespace GS_WINFORM
{
    public partial class MainForm : Form
    {

        // Inicializa os componentes da tela principal do sistema
        public MainForm()
        {
            InitializeComponent();
        }

        // Encerra o aplicativo
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento de clique em rotulo, caso necessario
        private void label1_Click(object sender, EventArgs e)
        {
        }


        // Abre o formulario para registrar uma nova falha
        private void btnRegistrarFalha_Click_1(object sender, EventArgs e)
        {
            RegistroFalhaForm form = new RegistroFalhaForm();
            this.Hide();
            form.ShowDialog();
        }

        // Abre formulario que exibe as falhas 
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FalhasForm form = new FalhasForm();
            this.Hide();
            form.ShowDialog();
        }


        // Abre o formulario de busca por falha
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaForm form = new BuscaForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
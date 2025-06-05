using System;
using System.Windows.Forms;

namespace GS_WINFORM
{
    public partial class RegistroFalhaForm : Form
    {

        // Inicializa a interface do registro
        public RegistroFalhaForm()
        {
            InitializeComponent();
        }

        // Botao para voltar um formulario
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        // Valida os dados e salva no arquivo JSON, caso seja duracao + que 10 minutos,exibe ALERTA
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParse(txtDataHora.Text, out DateTime dataHora))
                {
                    MessageBox.Show("Data inválida. Use o formato correto: ex: 2025-06-04 14:00", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtDuracao.Text, out int duracao))
                {
                    MessageBox.Show("Duração inválida. Use apenas números inteiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string local = txtLocal.Text.Trim();
                string impacto = txtImpacto.Text.Trim();

                if (string.IsNullOrWhiteSpace(local) || string.IsNullOrWhiteSpace(impacto))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FalhaEnergia falha = new FalhaEnergia
                {
                    Local = local,
                    Impacto = impacto,
                    DataHora = dataHora,
                    Duracao = duracao
                };

                FalhaStorage.SalvarFalha(falha);

                string log = $"Falha registrada em {local} às {dataHora}, duração {duracao} min. Impacto: {impacto}";

                if (duracao > 10)
                {
                    log += "\nALERTA CRÍTICO: Duração superior a 10 minutos.";
                }

                MessageBox.Show(log, "Falha Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                txtLocal.Clear();
                txtImpacto.Clear();
                txtDataHora.Clear();
                txtDuracao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar falha: {ex.Message}", "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


     // Nao implementado 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {
        }

        private void RegistroFalhaForm_Load(object sender, EventArgs e)
        {
        }
    }
}
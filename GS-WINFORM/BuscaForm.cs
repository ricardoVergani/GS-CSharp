using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GS_WINFORM
{
    public partial class BuscaForm : Form
    {

        // Construcao do formulario de busca.
        public BuscaForm()
        {
            InitializeComponent();
        }

        // Realiza a busca de falhas do local digitado e exibe no grid
        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar por local
            string local = txtLocal.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(local))
            {
                MessageBox.Show("Informe um local para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<FalhaEnergia> falhas = FalhaStorage.CarregarFalhas();
            var filtradas = falhas
                .Where(f => f.Local != null && f.Local.ToLower().Contains(local))
                .ToList();

            dataGridViewBusca.DataSource = null;
            dataGridViewBusca.DataSource = filtradas;
            AjustarCabecalhos();
        }

        // Reservado para ações ao clicar em células (Nao conseguimos implementar)
        private void dataGridViewBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se quiser tratar cliques nas células
        }

        // Evento ao digitar no campo ( Nao implementado )
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Evento de clique no label ( Nao implementado )
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Fecha o formulário atual e volta para a tela principal 
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }


        // Renomeia os nomes no grid
        private void AjustarCabecalhos()
        {
            if (dataGridViewBusca.Columns.Count > 0)
            {
                dataGridViewBusca.Columns["Local"].HeaderText = "Local";
                dataGridViewBusca.Columns["DataHora"].HeaderText = "Data e Hora";
                dataGridViewBusca.Columns["Impacto"].HeaderText = "Impacto";
                dataGridViewBusca.Columns["Duracao"].HeaderText = "Duração (min)";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GS_WINFORM
{
    public partial class FalhasForm : Form
    {
        public FalhasForm()
        {
            InitializeComponent();
            this.Load += FalhasForm_Load; // Garante que o evento Load está conectado
        }

        // Carrega os dados do JSON e os exibe no grid 
        private void FalhasForm_Load(object? sender, EventArgs e)
        {
            List<FalhaEnergia> falhas = FalhaStorage.CarregarFalhas();
            dataGridView1.DataSource = falhas;

            // Ajusta os nomes das colunas, se existirem
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Local"].HeaderText = "Local";
                dataGridView1.Columns["DataHora"].HeaderText = "Data e Hora";
                dataGridView1.Columns["Impacto"].HeaderText = "Impacto Causado";
                dataGridView1.Columns["Duracao"].HeaderText = "Duração (min)";
            }
        }


        // Evento de clique nas celulas ( Nao implementado )
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evento opcional
        }


        // Fecha o formulario atual e volta uma tela 
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }


        // Remove a linha selecionada do grid e remove do JSON
        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                var falhas = (List<FalhaEnergia>)dataGridView1.DataSource!;
                falhas.RemoveAt(index);

                // Salva a nova lista no arquivo
                FalhaStorage.SalvarFalhas(falhas);

                // Atualiza o DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = falhas;
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }
    }
}
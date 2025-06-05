namespace GS_WINFORM
{
    partial class BuscaForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuscarLocal = new Button();
            dataGridViewBusca = new DataGridView();
            btnVoltar = new Button();
            txtLocal = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusca).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarLocal
            // 
            btnBuscarLocal.Location = new Point(331, 84);
            btnBuscarLocal.Name = "btnBuscarLocal";
            btnBuscarLocal.Size = new Size(92, 23);
            btnBuscarLocal.TabIndex = 0;
            btnBuscarLocal.Text = "Buscar";
            btnBuscarLocal.UseVisualStyleBackColor = true;
            btnBuscarLocal.Click += button1_Click;
            // 
            // dataGridViewBusca
            // 
            dataGridViewBusca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusca.Location = new Point(261, 129);
            dataGridViewBusca.Name = "dataGridViewBusca";
            dataGridViewBusca.Size = new Size(240, 262);
            dataGridViewBusca.TabIndex = 1;
            dataGridViewBusca.CellContentClick += dataGridViewBusca_CellContentClick;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(685, 392);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(103, 46);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(309, 55);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(138, 23);
            txtLocal.TabIndex = 3;
            txtLocal.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 4;
            label1.Text = "Buscar por Local";
            label1.Click += label1_Click;
            // 
            // BuscaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtLocal);
            Controls.Add(btnVoltar);
            Controls.Add(dataGridViewBusca);
            Controls.Add(btnBuscarLocal);
            Name = "BuscaForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarLocal;
        private DataGridView dataGridViewBusca;
        private Button btnVoltar;
        private TextBox txtLocal;
        private Label label1;
    }
}
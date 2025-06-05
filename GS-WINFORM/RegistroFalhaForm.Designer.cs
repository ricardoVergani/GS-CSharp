namespace GS_WINFORM
{
    partial class RegistroFalhaForm
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
            btnSalvar = new Button();
            txtImpacto = new TextBox();
            txtDataHora = new TextBox();
            txtLocal = new TextBox();
            txtDuracao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(349, 290);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // txtImpacto
            // 
            txtImpacto.Location = new Point(349, 203);
            txtImpacto.Name = "txtImpacto";
            txtImpacto.Size = new Size(100, 23);
            txtImpacto.TabIndex = 1;
            // 
            // txtDataHora
            // 
            txtDataHora.Location = new Point(349, 151);
            txtDataHora.Name = "txtDataHora";
            txtDataHora.Size = new Size(100, 23);
            txtDataHora.TabIndex = 2;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(349, 99);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(100, 23);
            txtLocal.TabIndex = 3;
            txtLocal.TextChanged += txtLocal_TextChanged;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(349, 249);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(100, 23);
            txtDuracao.TabIndex = 4;
            txtDuracao.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(349, 223);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "Duracao";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(349, 177);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "Impacto causado";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(349, 125);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Data e Hora";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(349, 73);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "Local";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(692, 405);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(84, 33);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // RegistroFalhaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDuracao);
            Controls.Add(txtLocal);
            Controls.Add(txtDataHora);
            Controls.Add(txtImpacto);
            Controls.Add(btnSalvar);
            Name = "RegistroFalhaForm";
            Text = "Form1";
            Load += RegistroFalhaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtImpacto;
        private TextBox txtDataHora;
        private TextBox txtLocal;
        private TextBox txtDuracao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVoltar;
    }
}
namespace GS_WINFORM
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            btnSair = new Button();
            btnRegistrarFalha = new Button();
            label1 = new Label();
            btnVisualizar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(651, 386);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(137, 52);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button1_Click;
            // 
            // btnRegistrarFalha
            // 
            btnRegistrarFalha.Location = new Point(248, 162);
            btnRegistrarFalha.Name = "btnRegistrarFalha";
            btnRegistrarFalha.Size = new Size(263, 58);
            btnRegistrarFalha.TabIndex = 1;
            btnRegistrarFalha.Text = "Registrar Falha";
            btnRegistrarFalha.UseVisualStyleBackColor = true;
            btnRegistrarFalha.Click += btnRegistrarFalha_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 36);
            label1.Name = "label1";
            label1.Size = new Size(267, 66);
            label1.TabIndex = 2;
            label1.Text = "Bem Vindos a Luma! ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(248, 250);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(267, 59);
            btnVisualizar.TabIndex = 3;
            btnVisualizar.Text = "Visualizar Falhas";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(248, 337);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(267, 67);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnVisualizar);
            Controls.Add(label1);
            Controls.Add(btnRegistrarFalha);
            Controls.Add(btnSair);
            Name = "MainForm";
            Text = "Visualizar Falhas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnRegistrarFalha;
        private Label label1;
        private Button btnVisualizar;
        private Button btnBuscar;
    }
}
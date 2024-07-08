namespace UI
{
    partial class frmGerarRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            panel1 = new Panel();
            btnVoltar = new Button();
            lblRelatorios = new Label();
            btnSalvarRelatorio = new Button();
            btnGerarRelatorio = new Button();
            lblCaminhoRelatorio = new Label();
            lblColaborador = new Label();
            cboxColaborador = new ComboBox();
            txtCaminhoRelatorio = new TextBox();
            lblObservacoes = new Label();
            txtObservacao = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(lblRelatorios);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 58);
            panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(21, 14);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(43, 34);
            btnVoltar.TabIndex = 16;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblRelatorios
            // 
            lblRelatorios.AutoSize = true;
            lblRelatorios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRelatorios.ForeColor = SystemColors.Window;
            lblRelatorios.Location = new Point(223, 14);
            lblRelatorios.Name = "lblRelatorios";
            lblRelatorios.Size = new Size(219, 28);
            lblRelatorios.TabIndex = 0;
            lblRelatorios.Text = "Gerador de Relatórios";
            // 
            // btnSalvarRelatorio
            // 
            btnSalvarRelatorio.Location = new Point(469, 214);
            btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            btnSalvarRelatorio.Size = new Size(94, 29);
            btnSalvarRelatorio.TabIndex = 1;
            btnSalvarRelatorio.Text = "Procurar";
            btnSalvarRelatorio.UseVisualStyleBackColor = true;
            btnSalvarRelatorio.Click += btnCaminhoRelatorio_Click;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.BackColor = Color.RoyalBlue;
            btnGerarRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarRelatorio.ForeColor = SystemColors.Window;
            btnGerarRelatorio.Location = new Point(432, 498);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(131, 53);
            btnGerarRelatorio.TabIndex = 3;
            btnGerarRelatorio.Text = "Gerar";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // lblCaminhoRelatorio
            // 
            lblCaminhoRelatorio.AutoSize = true;
            lblCaminhoRelatorio.Location = new Point(90, 193);
            lblCaminhoRelatorio.Name = "lblCaminhoRelatorio";
            lblCaminhoRelatorio.Size = new Size(255, 20);
            lblCaminhoRelatorio.TabIndex = 1;
            lblCaminhoRelatorio.Text = "Escolha o caminho para salvar o PDF:";
            // 
            // lblColaborador
            // 
            lblColaborador.AutoSize = true;
            lblColaborador.Location = new Point(90, 117);
            lblColaborador.Name = "lblColaborador";
            lblColaborador.Size = new Size(158, 20);
            lblColaborador.TabIndex = 5;
            lblColaborador.Text = "Escolha o colaborador";
            // 
            // cboxColaborador
            // 
            cboxColaborador.FormattingEnabled = true;
            cboxColaborador.Location = new Point(90, 140);
            cboxColaborador.Name = "cboxColaborador";
            cboxColaborador.Size = new Size(201, 28);
            cboxColaborador.TabIndex = 6;
            // 
            // txtCaminhoRelatorio
            // 
            txtCaminhoRelatorio.Location = new Point(90, 216);
            txtCaminhoRelatorio.Name = "txtCaminhoRelatorio";
            txtCaminhoRelatorio.Size = new Size(362, 27);
            txtCaminhoRelatorio.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(90, 273);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(183, 20);
            lblObservacoes.TabIndex = 8;
            lblObservacoes.Text = "Observações do Relatório:";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(90, 296);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(473, 160);
            txtObservacao.TabIndex = 9;
            txtObservacao.Text = "";
            // 
            // frmGerarRelatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 596);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacoes);
            Controls.Add(cboxColaborador);
            Controls.Add(lblColaborador);
            Controls.Add(lblCaminhoRelatorio);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(txtCaminhoRelatorio);
            Controls.Add(btnSalvarRelatorio);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmGerarRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerarRelatorio";
            Load += frmGerarRelatorio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private Label lblRelatorios;
        private Button btnSalvarRelatorio;
        private Button btnGerarRelatorio;
        private Label lblCaminhoRelatorio;
        private Label lblColaborador;
        private ComboBox cboxColaborador;
        private TextBox txtCaminhoRelatorio;
        private Label lblObservacoes;
        private RichTextBox txtObservacao;
    }
}
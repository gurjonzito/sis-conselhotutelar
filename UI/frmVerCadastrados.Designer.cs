namespace UI
{
    partial class frmVerCadastrados
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
            panelVerCadastrados = new Panel();
            lblVerCadastrados = new Label();
            dataGridCidadao = new DataGridView();
            dataGridColaborador = new DataGridView();
            dataGridFamilia = new DataGridView();
            lblVerCidadao = new Label();
            lblVerFamilia = new Label();
            lblVerColaborador = new Label();
            txtVerCidadao = new TextBox();
            btnPesquisarCidadao = new Button();
            btnPesquisarFamilia = new Button();
            txtVerFamilia = new TextBox();
            btnPesquisarColaborador = new Button();
            txtVerColaborador = new TextBox();
            btnLimparTudo = new Button();
            panelVerCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidadao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridColaborador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFamilia).BeginInit();
            SuspendLayout();
            // 
            // panelVerCadastrados
            // 
            panelVerCadastrados.BackColor = Color.RoyalBlue;
            panelVerCadastrados.Controls.Add(lblVerCadastrados);
            panelVerCadastrados.Location = new Point(1, 1);
            panelVerCadastrados.Name = "panelVerCadastrados";
            panelVerCadastrados.Size = new Size(1110, 64);
            panelVerCadastrados.TabIndex = 0;
            // 
            // lblVerCadastrados
            // 
            lblVerCadastrados.AutoSize = true;
            lblVerCadastrados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerCadastrados.ForeColor = SystemColors.Window;
            lblVerCadastrados.Location = new Point(303, 19);
            lblVerCadastrados.Name = "lblVerCadastrados";
            lblVerCadastrados.Size = new Size(446, 31);
            lblVerCadastrados.TabIndex = 0;
            lblVerCadastrados.Text = "Visualizar pessoas e famílias cadastradas";
            // 
            // dataGridCidadao
            // 
            dataGridCidadao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidadao.Location = new Point(132, 210);
            dataGridCidadao.Name = "dataGridCidadao";
            dataGridCidadao.RowHeadersWidth = 51;
            dataGridCidadao.Size = new Size(377, 188);
            dataGridCidadao.TabIndex = 1;
            dataGridCidadao.CellMouseDoubleClick += dataGridCidadao_CellMouseDoubleClick;
            // 
            // dataGridColaborador
            // 
            dataGridColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridColaborador.Location = new Point(132, 541);
            dataGridColaborador.Name = "dataGridColaborador";
            dataGridColaborador.RowHeadersWidth = 51;
            dataGridColaborador.Size = new Size(814, 188);
            dataGridColaborador.TabIndex = 2;
            dataGridColaborador.CellMouseDoubleClick += dataGridColaborador_CellMouseDoubleClick;
            // 
            // dataGridFamilia
            // 
            dataGridFamilia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFamilia.Location = new Point(569, 210);
            dataGridFamilia.Name = "dataGridFamilia";
            dataGridFamilia.RowHeadersWidth = 51;
            dataGridFamilia.Size = new Size(377, 188);
            dataGridFamilia.TabIndex = 3;
            // 
            // lblVerCidadao
            // 
            lblVerCidadao.AutoSize = true;
            lblVerCidadao.Location = new Point(135, 119);
            lblVerCidadao.Name = "lblVerCidadao";
            lblVerCidadao.Size = new Size(65, 20);
            lblVerCidadao.TabIndex = 4;
            lblVerCidadao.Text = "Cidadão";
            // 
            // lblVerFamilia
            // 
            lblVerFamilia.AutoSize = true;
            lblVerFamilia.Location = new Point(569, 118);
            lblVerFamilia.Name = "lblVerFamilia";
            lblVerFamilia.Size = new Size(56, 20);
            lblVerFamilia.TabIndex = 5;
            lblVerFamilia.Text = "Família";
            // 
            // lblVerColaborador
            // 
            lblVerColaborador.AutoSize = true;
            lblVerColaborador.Location = new Point(132, 453);
            lblVerColaborador.Name = "lblVerColaborador";
            lblVerColaborador.Size = new Size(93, 20);
            lblVerColaborador.TabIndex = 6;
            lblVerColaborador.Text = "Colaborador";
            // 
            // txtVerCidadao
            // 
            txtVerCidadao.Location = new Point(132, 158);
            txtVerCidadao.Name = "txtVerCidadao";
            txtVerCidadao.Size = new Size(203, 27);
            txtVerCidadao.TabIndex = 7;
            // 
            // btnPesquisarCidadao
            // 
            btnPesquisarCidadao.Location = new Point(341, 157);
            btnPesquisarCidadao.Name = "btnPesquisarCidadao";
            btnPesquisarCidadao.Size = new Size(149, 29);
            btnPesquisarCidadao.TabIndex = 8;
            btnPesquisarCidadao.Text = "Pesquisar por nome";
            btnPesquisarCidadao.UseVisualStyleBackColor = true;
            btnPesquisarCidadao.Click += btnPesquisarCidadao_Click;
            // 
            // btnPesquisarFamilia
            // 
            btnPesquisarFamilia.Location = new Point(778, 157);
            btnPesquisarFamilia.Name = "btnPesquisarFamilia";
            btnPesquisarFamilia.Size = new Size(152, 29);
            btnPesquisarFamilia.TabIndex = 10;
            btnPesquisarFamilia.Text = "Pesquisar por nome";
            btnPesquisarFamilia.UseVisualStyleBackColor = true;
            // 
            // txtVerFamilia
            // 
            txtVerFamilia.Location = new Point(569, 158);
            txtVerFamilia.Name = "txtVerFamilia";
            txtVerFamilia.Size = new Size(203, 27);
            txtVerFamilia.TabIndex = 9;
            // 
            // btnPesquisarColaborador
            // 
            btnPesquisarColaborador.Location = new Point(450, 489);
            btnPesquisarColaborador.Name = "btnPesquisarColaborador";
            btnPesquisarColaborador.Size = new Size(163, 29);
            btnPesquisarColaborador.TabIndex = 12;
            btnPesquisarColaborador.Text = "Pesquisar por nome";
            btnPesquisarColaborador.UseVisualStyleBackColor = true;
            btnPesquisarColaborador.Click += btnPesquisarColaborador_Click;
            // 
            // txtVerColaborador
            // 
            txtVerColaborador.Location = new Point(132, 491);
            txtVerColaborador.Name = "txtVerColaborador";
            txtVerColaborador.Size = new Size(312, 27);
            txtVerColaborador.TabIndex = 11;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(132, 780);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(118, 29);
            btnLimparTudo.TabIndex = 13;
            btnLimparTudo.Text = "Limpar tudo";
            btnLimparTudo.UseVisualStyleBackColor = true;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // frmVerCadastrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 870);
            Controls.Add(btnLimparTudo);
            Controls.Add(btnPesquisarColaborador);
            Controls.Add(txtVerColaborador);
            Controls.Add(btnPesquisarFamilia);
            Controls.Add(txtVerFamilia);
            Controls.Add(btnPesquisarCidadao);
            Controls.Add(txtVerCidadao);
            Controls.Add(lblVerColaborador);
            Controls.Add(lblVerFamilia);
            Controls.Add(lblVerCidadao);
            Controls.Add(dataGridFamilia);
            Controls.Add(dataGridColaborador);
            Controls.Add(dataGridCidadao);
            Controls.Add(panelVerCadastrados);
            MaximizeBox = false;
            Name = "frmVerCadastrados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVerCadastrados";
            Load += frmVerCadastrados_Load;
            panelVerCadastrados.ResumeLayout(false);
            panelVerCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCidadao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridColaborador).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFamilia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelVerCadastrados;
        private DataGridView dataGridCidadao;
        private Label lblVerCadastrados;
        private DataGridView dataGridColaborador;
        private DataGridView dataGridFamilia;
        private Label lblVerCidadao;
        private Label lblVerFamilia;
        private Label lblVerColaborador;
        private TextBox txtVerCidadao;
        private Button btnPesquisarCidadao;
        private Button btnPesquisarFamilia;
        private TextBox txtVerFamilia;
        private Button btnPesquisarColaborador;
        private TextBox txtVerColaborador;
        private Button btnLimparTudo;
    }
}
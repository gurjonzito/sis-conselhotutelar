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
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            TelefoneCidadao = new DataGridViewTextBoxColumn();
            EmailCidadao = new DataGridViewTextBoxColumn();
            dataGridColaborador = new DataGridView();
            dataGridFamilia = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Responsável = new DataGridViewTextBoxColumn();
            Participantes = new DataGridViewTextBoxColumn();
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
            lblVerCadastrados.Location = new Point(233, 20);
            lblVerCadastrados.Name = "lblVerCadastrados";
            lblVerCadastrados.Size = new Size(446, 31);
            lblVerCadastrados.TabIndex = 0;
            lblVerCadastrados.Text = "Visualizar pessoas e famílias cadastradas";
            // 
            // dataGridCidadao
            // 
            dataGridCidadao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCidadao.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Idade, TelefoneCidadao, EmailCidadao });
            dataGridCidadao.Location = new Point(79, 210);
            dataGridCidadao.Name = "dataGridCidadao";
            dataGridCidadao.RowHeadersWidth = 51;
            dataGridCidadao.Size = new Size(303, 188);
            dataGridCidadao.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // Idade
            // 
            Idade.HeaderText = "Idade";
            Idade.MinimumWidth = 6;
            Idade.Name = "Idade";
            Idade.Width = 125;
            // 
            // TelefoneCidadao
            // 
            TelefoneCidadao.HeaderText = "Telefone";
            TelefoneCidadao.MinimumWidth = 6;
            TelefoneCidadao.Name = "TelefoneCidadao";
            TelefoneCidadao.Width = 125;
            // 
            // EmailCidadao
            // 
            EmailCidadao.HeaderText = "Email";
            EmailCidadao.MinimumWidth = 6;
            EmailCidadao.Name = "EmailCidadao";
            EmailCidadao.Width = 125;
            // 
            // dataGridColaborador
            // 
            dataGridColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridColaborador.Location = new Point(136, 542);
            dataGridColaborador.Name = "dataGridColaborador";
            dataGridColaborador.RowHeadersWidth = 51;
            dataGridColaborador.Size = new Size(648, 188);
            dataGridColaborador.TabIndex = 2;
            dataGridColaborador.CellMouseDoubleClick += dataGridColaborador_CellMouseDoubleClick;
            // 
            // dataGridFamilia
            // 
            dataGridFamilia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFamilia.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Responsável, Participantes });
            dataGridFamilia.Location = new Point(546, 210);
            dataGridFamilia.Name = "dataGridFamilia";
            dataGridFamilia.RowHeadersWidth = 51;
            dataGridFamilia.Size = new Size(303, 188);
            dataGridFamilia.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Sobrenome";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Responsável
            // 
            Responsável.HeaderText = "Responsável";
            Responsável.MinimumWidth = 6;
            Responsável.Name = "Responsável";
            Responsável.Width = 125;
            // 
            // Participantes
            // 
            Participantes.HeaderText = "Participantes";
            Participantes.MinimumWidth = 6;
            Participantes.Name = "Participantes";
            Participantes.Width = 125;
            // 
            // lblVerCidadao
            // 
            lblVerCidadao.AutoSize = true;
            lblVerCidadao.Location = new Point(82, 119);
            lblVerCidadao.Name = "lblVerCidadao";
            lblVerCidadao.Size = new Size(65, 20);
            lblVerCidadao.TabIndex = 4;
            lblVerCidadao.Text = "Cidadão";
            // 
            // lblVerFamilia
            // 
            lblVerFamilia.AutoSize = true;
            lblVerFamilia.Location = new Point(546, 119);
            lblVerFamilia.Name = "lblVerFamilia";
            lblVerFamilia.Size = new Size(56, 20);
            lblVerFamilia.TabIndex = 5;
            lblVerFamilia.Text = "Família";
            // 
            // lblVerColaborador
            // 
            lblVerColaborador.AutoSize = true;
            lblVerColaborador.Location = new Point(136, 454);
            lblVerColaborador.Name = "lblVerColaborador";
            lblVerColaborador.Size = new Size(93, 20);
            lblVerColaborador.TabIndex = 6;
            lblVerColaborador.Text = "Colaborador";
            // 
            // txtVerCidadao
            // 
            txtVerCidadao.Location = new Point(79, 158);
            txtVerCidadao.Name = "txtVerCidadao";
            txtVerCidadao.Size = new Size(203, 27);
            txtVerCidadao.TabIndex = 7;
            // 
            // btnPesquisarCidadao
            // 
            btnPesquisarCidadao.Location = new Point(288, 157);
            btnPesquisarCidadao.Name = "btnPesquisarCidadao";
            btnPesquisarCidadao.Size = new Size(94, 29);
            btnPesquisarCidadao.TabIndex = 8;
            btnPesquisarCidadao.Text = "Pesquisar por nome";
            btnPesquisarCidadao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarFamilia
            // 
            btnPesquisarFamilia.Location = new Point(755, 158);
            btnPesquisarFamilia.Name = "btnPesquisarFamilia";
            btnPesquisarFamilia.Size = new Size(94, 29);
            btnPesquisarFamilia.TabIndex = 10;
            btnPesquisarFamilia.Text = "Pesquisar por nome";
            btnPesquisarFamilia.UseVisualStyleBackColor = true;
            // 
            // txtVerFamilia
            // 
            txtVerFamilia.Location = new Point(546, 159);
            txtVerFamilia.Name = "txtVerFamilia";
            txtVerFamilia.Size = new Size(203, 27);
            txtVerFamilia.TabIndex = 9;
            // 
            // btnPesquisarColaborador
            // 
            btnPesquisarColaborador.Location = new Point(419, 491);
            btnPesquisarColaborador.Name = "btnPesquisarColaborador";
            btnPesquisarColaborador.Size = new Size(163, 29);
            btnPesquisarColaborador.TabIndex = 12;
            btnPesquisarColaborador.Text = "Pesquisar por nome";
            btnPesquisarColaborador.UseVisualStyleBackColor = true;
            btnPesquisarColaborador.Click += btnPesquisarColaborador_Click;
            // 
            // txtVerColaborador
            // 
            txtVerColaborador.Location = new Point(136, 492);
            txtVerColaborador.Name = "txtVerColaborador";
            txtVerColaborador.Size = new Size(277, 27);
            txtVerColaborador.TabIndex = 11;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.Location = new Point(79, 782);
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
            ClientSize = new Size(927, 870);
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
            Name = "frmVerCadastrados";
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn TelefoneCidadao;
        private DataGridViewTextBoxColumn EmailCidadao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Responsável;
        private DataGridViewTextBoxColumn Participantes;
        private Button btnLimparTudo;
    }
}
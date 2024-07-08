namespace UI
{
    partial class frmPermissoes
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
            cboxUserPermissao = new ComboBox();
            lstPermissaoExist = new ListBox();
            lblUserPermissao = new Label();
            lblPermissaoTrue = new Label();
            lblPermissaoFalse = new Label();
            lstPermissaoUser = new ListBox();
            btnAdicionarPermissao = new Button();
            btnRemoverPermissao = new Button();
            panelPermissao = new Panel();
            SuspendLayout();
            // 
            // cboxUserPermissao
            // 
            cboxUserPermissao.FormattingEnabled = true;
            cboxUserPermissao.Location = new Point(77, 91);
            cboxUserPermissao.Name = "cboxUserPermissao";
            cboxUserPermissao.Size = new Size(264, 28);
            cboxUserPermissao.TabIndex = 0;
            cboxUserPermissao.SelectedIndexChanged += cboxUserPermissao_SelectedIndexChanged;
            // 
            // lstPermissaoExist
            // 
            lstPermissaoExist.FormattingEnabled = true;
            lstPermissaoExist.Location = new Point(77, 180);
            lstPermissaoExist.Name = "lstPermissaoExist";
            lstPermissaoExist.Size = new Size(251, 164);
            lstPermissaoExist.TabIndex = 1;
            // 
            // lblUserPermissao
            // 
            lblUserPermissao.AutoSize = true;
            lblUserPermissao.Location = new Point(77, 68);
            lblUserPermissao.Name = "lblUserPermissao";
            lblUserPermissao.Size = new Size(59, 20);
            lblUserPermissao.TabIndex = 2;
            lblUserPermissao.Text = "Usuário";
            // 
            // lblPermissaoTrue
            // 
            lblPermissaoTrue.AutoSize = true;
            lblPermissaoTrue.Location = new Point(77, 157);
            lblPermissaoTrue.Name = "lblPermissaoTrue";
            lblPermissaoTrue.Size = new Size(150, 20);
            lblPermissaoTrue.TabIndex = 3;
            lblPermissaoTrue.Text = "Permissões existentes";
            // 
            // lblPermissaoFalse
            // 
            lblPermissaoFalse.AutoSize = true;
            lblPermissaoFalse.Location = new Point(388, 158);
            lblPermissaoFalse.Name = "lblPermissaoFalse";
            lblPermissaoFalse.Size = new Size(155, 20);
            lblPermissaoFalse.TabIndex = 4;
            lblPermissaoFalse.Text = "Permissões do usuário";
            // 
            // lstPermissaoUser
            // 
            lstPermissaoUser.FormattingEnabled = true;
            lstPermissaoUser.Location = new Point(388, 180);
            lstPermissaoUser.Name = "lstPermissaoUser";
            lstPermissaoUser.Size = new Size(251, 164);
            lstPermissaoUser.TabIndex = 5;
            // 
            // btnAdicionarPermissao
            // 
            btnAdicionarPermissao.Location = new Point(75, 397);
            btnAdicionarPermissao.Name = "btnAdicionarPermissao";
            btnAdicionarPermissao.Size = new Size(94, 29);
            btnAdicionarPermissao.TabIndex = 6;
            btnAdicionarPermissao.Text = "Adicionar";
            btnAdicionarPermissao.UseVisualStyleBackColor = true;
            btnAdicionarPermissao.Click += btnAdicionarPermissao_Click;
            // 
            // btnRemoverPermissao
            // 
            btnRemoverPermissao.Location = new Point(184, 397);
            btnRemoverPermissao.Name = "btnRemoverPermissao";
            btnRemoverPermissao.Size = new Size(94, 29);
            btnRemoverPermissao.TabIndex = 7;
            btnRemoverPermissao.Text = "Remover";
            btnRemoverPermissao.UseVisualStyleBackColor = true;
            btnRemoverPermissao.Click += btnRemoverPermissao_Click;
            // 
            // panelPermissao
            // 
            panelPermissao.BackColor = Color.RoyalBlue;
            panelPermissao.Location = new Point(0, -4);
            panelPermissao.Name = "panelPermissao";
            panelPermissao.Size = new Size(729, 35);
            panelPermissao.TabIndex = 8;
            // 
            // frmPermissoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(panelPermissao);
            Controls.Add(btnRemoverPermissao);
            Controls.Add(btnAdicionarPermissao);
            Controls.Add(lstPermissaoUser);
            Controls.Add(lblPermissaoFalse);
            Controls.Add(lblPermissaoTrue);
            Controls.Add(lblUserPermissao);
            Controls.Add(lstPermissaoExist);
            Controls.Add(cboxUserPermissao);
            MaximizeBox = false;
            Name = "frmPermissoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPermissoes";
            Load += frmPermissoes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxUserPermissao;
        private ListBox lstPermissaoExist;
        private Label lblUserPermissao;
        private Label lblPermissaoTrue;
        private Label lblPermissaoFalse;
        private ListBox lstPermissaoUser;
        private Button btnAdicionarPermissao;
        private Button btnRemoverPermissao;
        private Panel panelPermissao;
    }
}
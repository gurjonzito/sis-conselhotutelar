namespace UI
{
    partial class frmLogin
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
            lblUser = new Label();
            txtUser = new TextBox();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            panel1 = new Panel();
            lblBemVindo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(65, 55);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(59, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(65, 78);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(191, 27);
            txtUser.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(65, 183);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(191, 43);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(65, 131);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(191, 27);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(65, 108);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblBemVindo);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 37);
            panel1.TabIndex = 5;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.ForeColor = SystemColors.Window;
            lblBemVindo.Location = new Point(106, 8);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(105, 25);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem-vindo";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 263);
            Controls.Add(panel1);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnEntrar);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private TextBox txtUser;
        private Button btnEntrar;
        private TextBox txtSenha;
        private Label lblSenha;
        private Panel panel1;
        private Label lblBemVindo;
    }
}
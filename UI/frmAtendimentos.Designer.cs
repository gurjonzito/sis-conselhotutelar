namespace UI
{
    partial class frmAtendimentos
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
            cboxCargoUser = new ComboBox();
            lblCargoUser = new Label();
            lblConfirmSenhaUser = new Label();
            txtConfirmSenhaUser = new TextBox();
            txtID = new TextBox();
            panelNewUser = new Panel();
            btnVoltar = new Button();
            lblNewUser = new Label();
            btnLimparUser = new Button();
            btnAplicarUser = new Button();
            lblStatusAtend = new Label();
            lblDataAtend = new Label();
            txtCodigoAtend = new TextBox();
            lblCodigoAtend = new Label();
            dtDataAtend = new DateTimePicker();
            cboxStatusAtend = new ComboBox();
            panelNewUser.SuspendLayout();
            SuspendLayout();
            // 
            // cboxCargoUser
            // 
            cboxCargoUser.FormattingEnabled = true;
            cboxCargoUser.Items.AddRange(new object[] { "Administrador", "Conselheiro" });
            cboxCargoUser.Location = new Point(107, 402);
            cboxCargoUser.Name = "cboxCargoUser";
            cboxCargoUser.Size = new Size(191, 28);
            cboxCargoUser.TabIndex = 46;
            // 
            // lblCargoUser
            // 
            lblCargoUser.AutoSize = true;
            lblCargoUser.Location = new Point(108, 379);
            lblCargoUser.Name = "lblCargoUser";
            lblCargoUser.Size = new Size(78, 20);
            lblCargoUser.TabIndex = 45;
            lblCargoUser.Text = "Atendente";
            // 
            // lblConfirmSenhaUser
            // 
            lblConfirmSenhaUser.AutoSize = true;
            lblConfirmSenhaUser.Location = new Point(108, 306);
            lblConfirmSenhaUser.Name = "lblConfirmSenhaUser";
            lblConfirmSenhaUser.Size = new Size(65, 20);
            lblConfirmSenhaUser.TabIndex = 44;
            lblConfirmSenhaUser.Text = "Cidadão";
            // 
            // txtConfirmSenhaUser
            // 
            txtConfirmSenhaUser.Location = new Point(107, 329);
            txtConfirmSenhaUser.Name = "txtConfirmSenhaUser";
            txtConfirmSenhaUser.Size = new Size(192, 27);
            txtConfirmSenhaUser.TabIndex = 43;
            txtConfirmSenhaUser.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(188, 495);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 27);
            txtID.TabIndex = 42;
            txtID.Visible = false;
            // 
            // panelNewUser
            // 
            panelNewUser.BackColor = Color.RoyalBlue;
            panelNewUser.Controls.Add(btnVoltar);
            panelNewUser.Controls.Add(lblNewUser);
            panelNewUser.Location = new Point(-2, -4);
            panelNewUser.Name = "panelNewUser";
            panelNewUser.Size = new Size(440, 53);
            panelNewUser.TabIndex = 33;
            // 
            // btnVoltar
            // 
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.ImeMode = ImeMode.NoControl;
            btnVoltar.Location = new Point(10, 10);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.RightToLeft = RightToLeft.No;
            btnVoltar.Size = new Size(43, 34);
            btnVoltar.TabIndex = 28;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblNewUser
            // 
            lblNewUser.AutoSize = true;
            lblNewUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUser.ForeColor = SystemColors.Window;
            lblNewUser.Location = new Point(120, 10);
            lblNewUser.Name = "lblNewUser";
            lblNewUser.Size = new Size(190, 28);
            lblNewUser.TabIndex = 0;
            lblNewUser.Text = "Novo atendimento";
            // 
            // btnLimparUser
            // 
            btnLimparUser.BackColor = Color.RoyalBlue;
            btnLimparUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparUser.ForeColor = SystemColors.Window;
            btnLimparUser.Location = new Point(49, 487);
            btnLimparUser.Name = "btnLimparUser";
            btnLimparUser.Size = new Size(109, 40);
            btnLimparUser.TabIndex = 39;
            btnLimparUser.Text = "Limpar";
            btnLimparUser.UseVisualStyleBackColor = false;
            // 
            // btnAplicarUser
            // 
            btnAplicarUser.BackColor = Color.RoyalBlue;
            btnAplicarUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarUser.ForeColor = SystemColors.Window;
            btnAplicarUser.Location = new Point(263, 487);
            btnAplicarUser.Name = "btnAplicarUser";
            btnAplicarUser.Size = new Size(110, 40);
            btnAplicarUser.TabIndex = 41;
            btnAplicarUser.Text = "Aplicar";
            btnAplicarUser.UseVisualStyleBackColor = false;
            // 
            // lblStatusAtend
            // 
            lblStatusAtend.AutoSize = true;
            lblStatusAtend.Location = new Point(107, 231);
            lblStatusAtend.Name = "lblStatusAtend";
            lblStatusAtend.Size = new Size(49, 20);
            lblStatusAtend.TabIndex = 40;
            lblStatusAtend.Text = "Status";
            // 
            // lblDataAtend
            // 
            lblDataAtend.AutoSize = true;
            lblDataAtend.Location = new Point(107, 156);
            lblDataAtend.Name = "lblDataAtend";
            lblDataAtend.Size = new Size(41, 20);
            lblDataAtend.TabIndex = 37;
            lblDataAtend.Text = "Data";
            // 
            // txtCodigoAtend
            // 
            txtCodigoAtend.Location = new Point(107, 108);
            txtCodigoAtend.Name = "txtCodigoAtend";
            txtCodigoAtend.Size = new Size(192, 27);
            txtCodigoAtend.TabIndex = 35;
            // 
            // lblCodigoAtend
            // 
            lblCodigoAtend.AutoSize = true;
            lblCodigoAtend.Location = new Point(107, 85);
            lblCodigoAtend.Name = "lblCodigoAtend";
            lblCodigoAtend.Size = new Size(58, 20);
            lblCodigoAtend.TabIndex = 34;
            lblCodigoAtend.Text = "Código";
            // 
            // dtDataAtend
            // 
            dtDataAtend.Location = new Point(107, 179);
            dtDataAtend.Name = "dtDataAtend";
            dtDataAtend.Size = new Size(192, 27);
            dtDataAtend.TabIndex = 47;
            // 
            // cboxStatusAtend
            // 
            cboxStatusAtend.FormattingEnabled = true;
            cboxStatusAtend.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboxStatusAtend.Location = new Point(108, 254);
            cboxStatusAtend.Name = "cboxStatusAtend";
            cboxStatusAtend.Size = new Size(191, 28);
            cboxStatusAtend.TabIndex = 48;
            // 
            // frmAtendimentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 576);
            Controls.Add(cboxStatusAtend);
            Controls.Add(dtDataAtend);
            Controls.Add(cboxCargoUser);
            Controls.Add(lblCargoUser);
            Controls.Add(lblConfirmSenhaUser);
            Controls.Add(txtConfirmSenhaUser);
            Controls.Add(txtID);
            Controls.Add(panelNewUser);
            Controls.Add(btnLimparUser);
            Controls.Add(btnAplicarUser);
            Controls.Add(lblStatusAtend);
            Controls.Add(lblDataAtend);
            Controls.Add(txtCodigoAtend);
            Controls.Add(lblCodigoAtend);
            Name = "frmAtendimentos";
            Text = "frmAtendimentos";
            panelNewUser.ResumeLayout(false);
            panelNewUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxCargoUser;
        private Label lblCargoUser;
        private Label lblConfirmSenhaUser;
        private TextBox txtConfirmSenhaUser;
        private TextBox txtID;
        private Panel panelNewUser;
        private Button btnVoltar;
        private Label lblNewUser;
        private Button btnLimparUser;
        private Button btnAplicarUser;
        private Label lblStatusAtend;
        private Label lblDataAtend;
        private TextBox txtCodigoAtend;
        private Label lblCodigoAtend;
        private DateTimePicker dtDataAtend;
        private ComboBox cboxStatusAtend;
    }
}
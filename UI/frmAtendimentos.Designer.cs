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
            cboxAtendente = new ComboBox();
            lblCargoUser = new Label();
            lblConfirmSenhaUser = new Label();
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboxCidadaoAtend = new ComboBox();
            panelNewUser.SuspendLayout();
            SuspendLayout();
            // 
            // cboxAtendente
            // 
            cboxAtendente.FormattingEnabled = true;
            cboxAtendente.Items.AddRange(new object[] { "Administrador", "Conselheiro" });
            cboxAtendente.Location = new Point(61, 324);
            cboxAtendente.Name = "cboxAtendente";
            cboxAtendente.Size = new Size(302, 28);
            cboxAtendente.TabIndex = 46;
            // 
            // lblCargoUser
            // 
            lblCargoUser.AutoSize = true;
            lblCargoUser.Location = new Point(74, 301);
            lblCargoUser.Name = "lblCargoUser";
            lblCargoUser.Size = new Size(78, 20);
            lblCargoUser.TabIndex = 45;
            lblCargoUser.Text = "Atendente";
            // 
            // lblConfirmSenhaUser
            // 
            lblConfirmSenhaUser.AutoSize = true;
            lblConfirmSenhaUser.Location = new Point(74, 246);
            lblConfirmSenhaUser.Name = "lblConfirmSenhaUser";
            lblConfirmSenhaUser.Size = new Size(65, 20);
            lblConfirmSenhaUser.TabIndex = 44;
            lblConfirmSenhaUser.Text = "Cidadão";
            // 
            // txtID
            // 
            txtID.Location = new Point(191, 409);
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
            btnLimparUser.Location = new Point(52, 401);
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
            btnAplicarUser.Location = new Point(266, 401);
            btnAplicarUser.Name = "btnAplicarUser";
            btnAplicarUser.Size = new Size(110, 40);
            btnAplicarUser.TabIndex = 41;
            btnAplicarUser.Text = "Aplicar";
            btnAplicarUser.UseVisualStyleBackColor = false;
            btnAplicarUser.Click += btnAplicar_Click;
            // 
            // lblStatusAtend
            // 
            lblStatusAtend.AutoSize = true;
            lblStatusAtend.Location = new Point(73, 193);
            lblStatusAtend.Name = "lblStatusAtend";
            lblStatusAtend.Size = new Size(49, 20);
            lblStatusAtend.TabIndex = 40;
            lblStatusAtend.Text = "Status";
            // 
            // lblDataAtend
            // 
            lblDataAtend.AutoSize = true;
            lblDataAtend.Location = new Point(74, 138);
            lblDataAtend.Name = "lblDataAtend";
            lblDataAtend.Size = new Size(41, 20);
            lblDataAtend.TabIndex = 37;
            lblDataAtend.Text = "Data";
            // 
            // txtCodigoAtend
            // 
            txtCodigoAtend.Location = new Point(62, 108);
            txtCodigoAtend.Name = "txtCodigoAtend";
            txtCodigoAtend.Size = new Size(302, 27);
            txtCodigoAtend.TabIndex = 35;
            // 
            // lblCodigoAtend
            // 
            lblCodigoAtend.AutoSize = true;
            lblCodigoAtend.Location = new Point(74, 85);
            lblCodigoAtend.Name = "lblCodigoAtend";
            lblCodigoAtend.Size = new Size(58, 20);
            lblCodigoAtend.TabIndex = 34;
            lblCodigoAtend.Text = "Código";
            // 
            // dtDataAtend
            // 
            dtDataAtend.Location = new Point(62, 161);
            dtDataAtend.Name = "dtDataAtend";
            dtDataAtend.Size = new Size(303, 27);
            dtDataAtend.TabIndex = 47;
            // 
            // cboxStatusAtend
            // 
            cboxStatusAtend.FormattingEnabled = true;
            cboxStatusAtend.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboxStatusAtend.Location = new Point(62, 216);
            cboxStatusAtend.Name = "cboxStatusAtend";
            cboxStatusAtend.Size = new Size(302, 28);
            cboxStatusAtend.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(62, 85);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 49;
            label1.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(62, 301);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 52;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(62, 193);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 53;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(62, 138);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 54;
            label6.Text = "*";
            // 
            // cboxCidadaoAtend
            // 
            cboxCidadaoAtend.FormattingEnabled = true;
            cboxCidadaoAtend.Items.AddRange(new object[] { "Administrador", "Conselheiro" });
            cboxCidadaoAtend.Location = new Point(61, 269);
            cboxCidadaoAtend.Name = "cboxCidadaoAtend";
            cboxCidadaoAtend.Size = new Size(302, 28);
            cboxCidadaoAtend.TabIndex = 55;
            // 
            // frmAtendimentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 491);
            Controls.Add(cboxCidadaoAtend);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cboxStatusAtend);
            Controls.Add(dtDataAtend);
            Controls.Add(cboxAtendente);
            Controls.Add(lblCargoUser);
            Controls.Add(lblConfirmSenhaUser);
            Controls.Add(txtID);
            Controls.Add(panelNewUser);
            Controls.Add(btnLimparUser);
            Controls.Add(btnAplicarUser);
            Controls.Add(lblStatusAtend);
            Controls.Add(lblDataAtend);
            Controls.Add(txtCodigoAtend);
            Controls.Add(lblCodigoAtend);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAtendimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAtendimentos";
            panelNewUser.ResumeLayout(false);
            panelNewUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxAtendente;
        private Label lblCargoUser;
        private Label lblConfirmSenhaUser;
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
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboxCidadaoAtend;
    }
}
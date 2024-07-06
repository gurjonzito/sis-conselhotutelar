namespace UI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            toolStripPrincipal = new ToolStrip();
            toolStripCad = new ToolStripDropDownButton();
            toolStripUser = new ToolStripMenuItem();
            toolStripAtendimento = new ToolStripMenuItem();
            toolStripCaso = new ToolStripMenuItem();
            cidadãoToolStripMenuItem = new ToolStripMenuItem();
            famíliaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripView = new ToolStripDropDownButton();
            toolStripViewCadastros = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripRelatorio = new ToolStripDropDownButton();
            toolStripGerar = new ToolStripMenuItem();
            toolStripOpcoes = new ToolStripDropDownButton();
            toolStripPermissoes = new ToolStripMenuItem();
            toolStripSair = new ToolStripLabel();
            panelPrincipal = new Panel();
            label1 = new Label();
            label2 = new Label();
            toolStripEditar = new ToolStripDropDownButton();
            toolStripEditarColab = new ToolStripMenuItem();
            senhaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripPrincipal.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripPrincipal
            // 
            toolStripPrincipal.ImageScalingSize = new Size(20, 20);
            toolStripPrincipal.Items.AddRange(new ToolStripItem[] { toolStripCad, toolStripSeparator2, toolStripView, toolStripSeparator3, toolStripRelatorio, toolStripSair, toolStripSeparator1, toolStripEditar, toolStripSeparator4, toolStripOpcoes });
            toolStripPrincipal.Location = new Point(0, 0);
            toolStripPrincipal.Name = "toolStripPrincipal";
            toolStripPrincipal.Size = new Size(811, 30);
            toolStripPrincipal.TabIndex = 0;
            toolStripPrincipal.Text = "toolStrip1";
            // 
            // toolStripCad
            // 
            toolStripCad.DropDownItems.AddRange(new ToolStripItem[] { toolStripUser, toolStripAtendimento, toolStripCaso, cidadãoToolStripMenuItem, famíliaToolStripMenuItem });
            toolStripCad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripCad.Name = "toolStripCad";
            toolStripCad.Size = new Size(65, 27);
            toolStripCad.Text = "Novo";
            // 
            // toolStripUser
            // 
            toolStripUser.Name = "toolStripUser";
            toolStripUser.Size = new Size(224, 28);
            toolStripUser.Text = "Colaborador";
            toolStripUser.Click += toolStripUser_Click;
            // 
            // toolStripAtendimento
            // 
            toolStripAtendimento.Name = "toolStripAtendimento";
            toolStripAtendimento.Size = new Size(224, 28);
            toolStripAtendimento.Text = "Atendimento";
            // 
            // toolStripCaso
            // 
            toolStripCaso.Name = "toolStripCaso";
            toolStripCaso.Size = new Size(224, 28);
            toolStripCaso.Text = "Caso";
            // 
            // cidadãoToolStripMenuItem
            // 
            cidadãoToolStripMenuItem.Name = "cidadãoToolStripMenuItem";
            cidadãoToolStripMenuItem.Size = new Size(224, 28);
            cidadãoToolStripMenuItem.Text = "Cidadão";
            // 
            // famíliaToolStripMenuItem
            // 
            famíliaToolStripMenuItem.Name = "famíliaToolStripMenuItem";
            famíliaToolStripMenuItem.Size = new Size(224, 28);
            famíliaToolStripMenuItem.Text = "Família";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // toolStripView
            // 
            toolStripView.DropDownItems.AddRange(new ToolStripItem[] { toolStripViewCadastros });
            toolStripView.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripView.Name = "toolStripView";
            toolStripView.Size = new Size(96, 27);
            toolStripView.Text = "Visualizar";
            // 
            // toolStripViewCadastros
            // 
            toolStripViewCadastros.Name = "toolStripViewCadastros";
            toolStripViewCadastros.Size = new Size(169, 28);
            toolStripViewCadastros.Text = "Cadastros";
            toolStripViewCadastros.Click += toolStripViewCadastros_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 30);
            // 
            // toolStripRelatorio
            // 
            toolStripRelatorio.DropDownItems.AddRange(new ToolStripItem[] { toolStripGerar });
            toolStripRelatorio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripRelatorio.Name = "toolStripRelatorio";
            toolStripRelatorio.Size = new Size(99, 27);
            toolStripRelatorio.Text = "Relatórios";
            // 
            // toolStripGerar
            // 
            toolStripGerar.Name = "toolStripGerar";
            toolStripGerar.Size = new Size(136, 28);
            toolStripGerar.Text = "Gerar";
            toolStripGerar.Click += toolStripGerar_Click;
            // 
            // toolStripOpcoes
            // 
            toolStripOpcoes.DropDownItems.AddRange(new ToolStripItem[] { toolStripPermissoes });
            toolStripOpcoes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripOpcoes.Name = "toolStripOpcoes";
            toolStripOpcoes.Size = new Size(81, 27);
            toolStripOpcoes.Text = "Opções";
            // 
            // toolStripPermissoes
            // 
            toolStripPermissoes.Name = "toolStripPermissoes";
            toolStripPermissoes.Size = new Size(224, 28);
            toolStripPermissoes.Text = "Permissões";
            toolStripPermissoes.Click += toolStripPermissoes_Click;
            // 
            // toolStripSair
            // 
            toolStripSair.Alignment = ToolStripItemAlignment.Right;
            toolStripSair.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripSair.Name = "toolStripSair";
            toolStripSair.Size = new Size(38, 27);
            toolStripSair.Text = "Sair";
            toolStripSair.Click += toolStripSair_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.BackColor = Color.RoyalBlue;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(0, 33);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(811, 37);
            panelPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(252, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 28);
            label1.TabIndex = 0;
            label1.Text = "Sistema do Conselho Tutelar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 587);
            label2.Name = "label2";
            label2.Size = new Size(212, 20);
            label2.TabIndex = 2;
            label2.Text = "Desenvolvido por @gurjonzito";
            // 
            // toolStripEditar
            // 
            toolStripEditar.DropDownItems.AddRange(new ToolStripItem[] { toolStripEditarColab, senhaToolStripMenuItem });
            toolStripEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripEditar.Name = "toolStripEditar";
            toolStripEditar.Size = new Size(68, 27);
            toolStripEditar.Text = "Editar";
            // 
            // toolStripEditarColab
            // 
            toolStripEditarColab.Name = "toolStripEditarColab";
            toolStripEditarColab.Size = new Size(224, 28);
            toolStripEditarColab.Text = "Colaborador";
            // 
            // senhaToolStripMenuItem
            // 
            senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            senhaToolStripMenuItem.Size = new Size(224, 28);
            senhaToolStripMenuItem.Text = "Senha";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 30);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 616);
            Controls.Add(label2);
            Controls.Add(panelPrincipal);
            Controls.Add(toolStripPrincipal);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            toolStripPrincipal.ResumeLayout(false);
            toolStripPrincipal.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripPrincipal;
        private ToolStripLabel toolStripSair;
        private ToolStripDropDownButton toolStripCad;
        private ToolStripMenuItem toolStripUser;
        private ToolStripMenuItem toolStripAtendimento;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Panel panelPrincipal;
        private ToolStripMenuItem toolStripCaso;
        private ToolStripDropDownButton toolStripRelatorio;
        private ToolStripMenuItem toolStripGerar;
        private Label label1;
        private Label label2;
        private ToolStripDropDownButton toolStripOpcoes;
        private ToolStripMenuItem toolStripPermissoes;
        private ToolStripMenuItem cidadãoToolStripMenuItem;
        private ToolStripMenuItem famíliaToolStripMenuItem;
        private ToolStripDropDownButton toolStripView;
        private ToolStripMenuItem toolStripViewCadastros;
        private ToolStripDropDownButton toolStripEditar;
        private ToolStripMenuItem toolStripEditarColab;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem senhaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
    }
}
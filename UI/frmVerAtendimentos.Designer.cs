namespace UI
{
    partial class frmVerAtendimentos
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
            label2 = new Label();
            label1 = new Label();
            btnPesquisarAtend = new Button();
            txtVerAtend = new TextBox();
            dataGridAtend = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAtend).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(148, 9);
            label2.Name = "label2";
            label2.Size = new Size(359, 28);
            label2.TabIndex = 2;
            label2.Text = "Visualizar atendimentos cadastrados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Atendimento";
            // 
            // btnPesquisarAtend
            // 
            btnPesquisarAtend.Location = new Point(284, 132);
            btnPesquisarAtend.Name = "btnPesquisarAtend";
            btnPesquisarAtend.Size = new Size(162, 29);
            btnPesquisarAtend.TabIndex = 11;
            btnPesquisarAtend.Text = "Pesquisar por código";
            btnPesquisarAtend.UseVisualStyleBackColor = true;
            btnPesquisarAtend.Click += btnPesquisarAtend_Click;
            // 
            // txtVerAtend
            // 
            txtVerAtend.Location = new Point(75, 133);
            txtVerAtend.Name = "txtVerAtend";
            txtVerAtend.Size = new Size(203, 27);
            txtVerAtend.TabIndex = 1;
            // 
            // dataGridAtend
            // 
            dataGridAtend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAtend.Location = new Point(75, 185);
            dataGridAtend.Name = "dataGridAtend";
            dataGridAtend.ReadOnly = true;
            dataGridAtend.RowHeadersWidth = 51;
            dataGridAtend.Size = new Size(509, 188);
            dataGridAtend.TabIndex = 9;
            dataGridAtend.CellMouseDoubleClick += dataGridAtendimento_CellMouseDoubleClick;
            // 
            // frmVerAtendimentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(btnPesquisarAtend);
            Controls.Add(txtVerAtend);
            Controls.Add(dataGridAtend);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmVerAtendimentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVerAtendimentos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAtend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnPesquisarAtend;
        private TextBox txtVerAtend;
        private DataGridView dataGridAtend;
    }
}
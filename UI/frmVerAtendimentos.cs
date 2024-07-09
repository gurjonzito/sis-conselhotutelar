using BLL;
using DAL;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmVerAtendimentos : Form
    {
        private AtendimentoBLL atendimentoBLL = new AtendimentoBLL();
        private List<Atendimento> atendimentos = new List<Atendimento>();

        public frmVerAtendimentos()
        {
            InitializeComponent();
            Load += frmVerAtendimentos_Load;
        }

        private void frmVerAtendimentos_Load(object sender, EventArgs e)
        {
            LoadAtendimento();
            btnPesquisarAtend.Click += new EventHandler(btnPesquisarAtend_Click);
            //btnLimparTudo.Click += new EventHandler(btnLimparTudo_Click);
            dataGridAtend.CellMouseDoubleClick += dataGridAtendimento_CellMouseDoubleClick;
        }

        private void LoadAtendimento()
        {
            atendimentos = atendimentoBLL.GetAtendimentosComNomes();
            dataGridAtend.DataSource = atendimentos;

            // Especificar quais colunas devem ser exibidas e a ordem
            dataGridAtend.Columns["IdAtendimento"].DisplayIndex = 0;
            dataGridAtend.Columns["IdAtendimento"].HeaderText = "ID";

            dataGridAtend.Columns["CodigoAtendimento"].DisplayIndex = 1;
            dataGridAtend.Columns["CodigoAtendimento"].HeaderText = "Código";

            dataGridAtend.Columns["DataAtendimento"].DisplayIndex = 2;
            dataGridAtend.Columns["DataAtendimento"].HeaderText = "Data";

            dataGridAtend.Columns["StatusAtendimento"].DisplayIndex = 3;
            dataGridAtend.Columns["StatusAtendimento"].HeaderText = "Status";

            dataGridAtend.Columns["NomeCidadao"].DisplayIndex = 4;
            dataGridAtend.Columns["NomeCidadao"].HeaderText = "Cidadão";

            dataGridAtend.Columns["NomeAtendente"].DisplayIndex = 5;
            dataGridAtend.Columns["NomeAtendente"].HeaderText = "Responsável";

            // Ocultar todas as outras colunas
            foreach (DataGridViewColumn column in dataGridAtend.Columns)
            {
                if (column.Name != "IdAtendimento" && column.Name != "CodigoAtendimento" && column.Name != "DataAtendimento" && column.Name != "StatusAtendimento" && column.Name != "NomeCidadao" && column.Name != "NomeAtendente")
                {
                    column.Visible = false;
                }
            }
        }

        private void btnPesquisarAtend_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtVerAtend.Text.Trim();

            if (string.IsNullOrEmpty(nomePesquisado))
            {
                MessageBox.Show("Digite um código e tente novamente.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerAtend.Focus();
                return;
            }

            var atendimentosFiltrados = atendimentos
                .Where(c => c.CodigoAtendimento.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (atendimentosFiltrados.Count == 0)
            {
                MessageBox.Show("Cidadão não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridAtend.DataSource = atendimentosFiltrados;
        }

        private void dataGridAtendimento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridAtend.Rows[e.RowIndex];
                string codigo = selectedRow.Cells["CodigoAtendimento"].Value as string;

                if (!string.IsNullOrEmpty(codigo))
                {
                    Atendimento atendimento = atendimentos.Find(f => f.CodigoAtendimento == codigo);
                }
            }
        }
    }
}

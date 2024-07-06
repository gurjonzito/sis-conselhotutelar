using BLL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class frmVerCadastrados : Form
    {
        private ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        private List<Colaborador> colaboradores = new List<Colaborador>();

        public frmVerCadastrados()
        {
            InitializeComponent();
            Load += frmVerCadastrados_Load;
        }

        private void frmVerCadastrados_Load(object sender, EventArgs e)
        {
            LoadColaboradores();
            btnPesquisarColaborador.Click += new EventHandler(btnPesquisarColaborador_Click);
            //btnVoltar.Click += new EventHandler(btnVoltar_Click);
            btnLimparTudo.Click += new EventHandler(btnLimparTudo_Click);
            dataGridColaborador.CellMouseDoubleClick += dataGridColaborador_CellMouseDoubleClick;
        }

        private void LoadColaboradores()
        {
            colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor();
            dataGridColaborador.DataSource = colaboradores;

            // Especificar quais colunas devem ser exibidas
            dataGridColaborador.Columns["IdColaborador"].HeaderText = "ID";
            dataGridColaborador.Columns["NomeColaborador"].HeaderText = "Nome";
            dataGridColaborador.Columns["EmailColaborador"].HeaderText = "Email";
            dataGridColaborador.Columns["TelefoneColaborador"].HeaderText = "Telefone";
            dataGridColaborador.Columns["NomeCargo"].HeaderText = "Cargo";

            // Ocultar todas as outras colunas
            foreach (DataGridViewColumn column in dataGridColaborador.Columns)
            {
                if (column.Name != "IdColaborador" && column.Name != "NomeColaborador" && column.Name != "EmailColaborador" && column.Name != "TelefoneColaborador" && column.Name != "NomeCargo")
                {
                    column.Visible = false;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtVerColaborador.Text = string.Empty;
        }

        private void btnPesquisarColaborador_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtVerColaborador.Text.Trim();

            if (string.IsNullOrEmpty(nomePesquisado))
            {
                MessageBox.Show("Digite um nome e tente novamente.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerColaborador.Focus();
                return;
            }

            var colaboradoresFiltrados = colaboradores
                .Where(c => c.NomeColaborador.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (colaboradoresFiltrados.Count == 0)
            {
                MessageBox.Show("Colaborador não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridColaborador.DataSource = colaboradoresFiltrados;
        }

        private void dataGridColaborador_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridColaborador.Rows[e.RowIndex];
                string NomeColaborador = selectedRow.Cells["NomeColaborador"].Value as string;

                if (!string.IsNullOrEmpty(NomeColaborador))
                {
                    Colaborador colaborador = colaboradores.Find(f => f.NomeColaborador == NomeColaborador);
                    // Execute alguma ação com o colaborador selecionado, se necessário
                }
            }
        }
    }
}

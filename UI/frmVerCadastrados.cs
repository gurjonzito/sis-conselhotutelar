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
        private FamiliaBLL familiaBLL = new FamiliaBLL();
        private List<Familia> familias = new List<Familia>();

        private CidadaoBLL cidadaoBLL = new CidadaoBLL();
        private List<Cidadao> cidadaos = new List<Cidadao>();

        private ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        private List<Colaborador> colaboradores = new List<Colaborador>();

        public frmVerCadastrados()
        {
            InitializeComponent();
            Load += frmVerCadastrados_Load;
        }

        private void frmVerCadastrados_Load(object sender, EventArgs e)
        {
            LoadCidadaos();
            LoadFamilias();
            LoadColaboradores();
            btnPesquisarColaborador.Click += new EventHandler(btnPesquisarColaborador_Click);
            btnPesquisarCidadao.Click += new EventHandler(btnPesquisarCidadao_Click);
            btnPesquisarFamilia.Click += new EventHandler(btnPesquisarFamilia_Click);
            btnLimparTudo.Click += new EventHandler(btnLimparTudo_Click);
            dataGridColaborador.CellMouseDoubleClick += dataGridColaborador_CellMouseDoubleClick;
            dataGridCidadao.CellMouseDoubleClick += dataGridCidadao_CellMouseDoubleClick;
            dataGridFamilia.CellMouseDoubleClick += dataGridFamilia_CellMouseDoubleClick;
        }

        private void LoadCidadaos()
        {
            cidadaos = cidadaoBLL.GetCidadaosComFamilia();
            dataGridCidadao.DataSource = cidadaos;

            // Especificar quais colunas devem ser exibidas e a ordem
            dataGridCidadao.Columns["IdCidadao"].DisplayIndex = 0;
            dataGridCidadao.Columns["IdCidadao"].HeaderText = "ID";

            dataGridCidadao.Columns["NomeCidadao"].DisplayIndex = 1;
            dataGridCidadao.Columns["NomeCidadao"].HeaderText = "Nome";

            dataGridCidadao.Columns["IdadeCidadao"].DisplayIndex = 2;
            dataGridCidadao.Columns["IdadeCidadao"].HeaderText = "Idade";

            dataGridCidadao.Columns["TelefoneCidadao"].DisplayIndex = 3;
            dataGridCidadao.Columns["TelefoneCidadao"].HeaderText = "Telefone";

            dataGridCidadao.Columns["EmailCidadao"].DisplayIndex = 4;
            dataGridCidadao.Columns["EmailCidadao"].HeaderText = "Email";

            dataGridCidadao.Columns["NomeFamilia"].DisplayIndex = 5;
            dataGridCidadao.Columns["NomeFamilia"].HeaderText = "Família";

            // Ocultar todas as outras colunas
            foreach (DataGridViewColumn column in dataGridCidadao.Columns)
            {
                if (column.Name != "IdCidadao" && column.Name != "NomeCidadao" && column.Name != "IdadeCidadao" && column.Name != "TelefoneCidadao" && column.Name != "EmailCidadao" && column.Name != "NomeFamilia")
                {
                    column.Visible = false;
                }
            }
        }

        private void btnPesquisarCidadao_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtVerCidadao.Text.Trim();

            if (string.IsNullOrEmpty(nomePesquisado))
            {
                MessageBox.Show("Digite um nome e tente novamente.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerCidadao.Focus();
                return;
            }

            var cidadaosFiltrados = cidadaos
                .Where(c => c.NomeCidadao.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (cidadaosFiltrados.Count == 0)
            {
                MessageBox.Show("Cidadão não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridCidadao.DataSource = cidadaosFiltrados;
        }

        private void dataGridCidadao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridCidadao.Rows[e.RowIndex];
                string NomeCidadao = selectedRow.Cells["NomeCidadao"].Value as string;

                if (!string.IsNullOrEmpty(NomeCidadao))
                {
                    Cidadao cidadao = cidadaos.Find(f => f.NomeCidadao == NomeCidadao);
                    // Execute alguma ação com o cidadão selecionado, se necessário
                }
            }
        }

        private void LoadFamilias()
        {
            familias = familiaBLL.ObterFamilias();
            dataGridFamilia.DataSource = familias;

            // Especificar quais colunas devem ser exibidas e a ordem
            dataGridFamilia.Columns["Id"].DisplayIndex = 0;
            dataGridFamilia.Columns["Id"].HeaderText = "ID";

            dataGridFamilia.Columns["Sobrenome"].DisplayIndex = 1;
            dataGridFamilia.Columns["Sobrenome"].HeaderText = "Sobrenomes";

            dataGridFamilia.Columns["Responsavel"].DisplayIndex = 2;
            dataGridFamilia.Columns["Responsavel"].HeaderText = "Responsável";

            dataGridFamilia.Columns["Participantes"].DisplayIndex = 3;
            dataGridFamilia.Columns["Participantes"].HeaderText = "Participantes";

            // Ocultar todas as outras colunas
            foreach (DataGridViewColumn column in dataGridFamilia.Columns)
            {
                if (column.Name != "Id" && column.Name != "Sobrenome" && column.Name != "Responsavel" && column.Name != "Participantes")
                {
                    column.Visible = false;
                }
            }
        }

        private void btnPesquisarFamilia_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtVerFamilia.Text.Trim();

            if (string.IsNullOrEmpty(nomePesquisado))
            {
                MessageBox.Show("Digite um nome e tente novamente.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerFamilia.Focus();
                return;
            }

            var familiasFiltradas = familias
                .Where(c => c.Sobrenome.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (familiasFiltradas.Count == 0)
            {
                MessageBox.Show("Família não encontrada.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridFamilia.DataSource = familiasFiltradas;
        }

        private void dataGridFamilia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridFamilia.Rows[e.RowIndex];
                string SobrenomeFamilia = selectedRow.Cells["Sobrenome"].Value as string;

                if (!string.IsNullOrEmpty(SobrenomeFamilia))
                {
                    Familia familia = familias.Find(f => f.Sobrenome == SobrenomeFamilia);
                }
            }
        }

        private void LoadColaboradores()
        {
            colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor();
            dataGridColaborador.DataSource = colaboradores;

            // Especificar quais colunas devem ser exibidas e a ordem
            dataGridColaborador.Columns["IdColaborador"].DisplayIndex = 0;
            dataGridColaborador.Columns["IdColaborador"].HeaderText = "ID";

            dataGridColaborador.Columns["NomeColaborador"].DisplayIndex = 1;
            dataGridColaborador.Columns["NomeColaborador"].HeaderText = "Nome";

            dataGridColaborador.Columns["EmailColaborador"].DisplayIndex = 2;
            dataGridColaborador.Columns["EmailColaborador"].HeaderText = "Email";

            dataGridColaborador.Columns["TelefoneColaborador"].DisplayIndex = 3;
            dataGridColaborador.Columns["TelefoneColaborador"].HeaderText = "Telefone";

            dataGridColaborador.Columns["NomeCargo"].DisplayIndex = 4;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtVerColaborador.Text = string.Empty;
            txtVerCidadao.Text = string.Empty;
            txtVerFamilia.Text = string.Empty;
            LoadCidadaos();
            LoadColaboradores();
            LoadFamilias();
        }
    }
}
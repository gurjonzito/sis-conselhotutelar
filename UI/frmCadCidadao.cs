using BLL;
using model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCadCidadao : Form
    {
        private CidadaoBLL cidadaoBLL = new CidadaoBLL();
        private FamiliaBLL familiaBLL = new FamiliaBLL();
        private List<Familia> familias = new List<Familia>();

        public frmCadCidadao()
        {
            InitializeComponent();
            CarregarFamilias();
        }

        private void CarregarFamilias()
        {
            familias = familiaBLL.ObterFamilias();
            if (familias != null && familias.Count > 0)
            {
                cboxFamiliaCidadao.DataSource = familias;
                cboxFamiliaCidadao.DisplayMember = "Sobrenome";
                cboxFamiliaCidadao.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Não há famílias cadastradas.");
            }
        }

        private void btnAplicarCidadao_Click(object sender, EventArgs e)
        {
            Cidadao cidadao = new Cidadao();

            if (!string.IsNullOrEmpty(txtID.Text))
                cidadao.IdCidadao = int.Parse(txtID.Text);

            cidadao.NomeCidadao = txtNomeCidadao.Text.Trim();
            if (int.TryParse(txtIdadeCidadao.Text.Trim(), out int idadeCidadao))
            {
                cidadao.IdadeCidadao = idadeCidadao;
            }
            else
            {
                MessageBox.Show("Idade inválida.");
                return;
            }

            cidadao.TelefoneCidadao = txtTelCidadao.Text.Trim();
            cidadao.EmailCidadao = txtEmailCidadao.Text.Trim();

            if (string.IsNullOrWhiteSpace(cidadao.NomeCidadao))
            {
                MessageBox.Show("Nome deve ser preenchido.");
                return;
            }

            if (cidadao.EmailCidadao.Contains(" "))
            {
                MessageBox.Show("E-mail não pode conter espaços em branco.");
                return;
            }

            if (!CidadaoBLL.IsValidEmail(cidadao.EmailCidadao))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Atribuir IdFamiliaCidadao se houver um valor selecionado na ComboBox
            if (cboxFamiliaCidadao.SelectedIndex != -1)
            {
                // Certifique-se de que o valor é convertido corretamente para int
                cidadao.IdFamiliaCidadao = (int?)cboxFamiliaCidadao.SelectedValue;
            }
            else
            {
                cidadao.IdFamiliaCidadao = null; // Ou outro valor padrão de sua escolha
            }

            string retorno;

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                // Atualizar cidadão
                retorno = cidadaoBLL.UpdateCidadao(cidadao);
            }
            else
            {
                // Verificar se o cidadão já existe
                if (cidadaoBLL.VerificarCidadao(cidadao.IdCidadao) == "Cidadão existente")
                {
                    MessageBox.Show("O cidadão já existe no banco de dados.");
                    return;
                }

                // Inserir novo cidadão
                retorno = cidadaoBLL.CadastrarCidadao(cidadao);
            }

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");
                btnLimparCidadao.PerformClick();
            }
        }

        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtNomeCidadao.Text = string.Empty;
            txtIdadeCidadao.Text = string.Empty;
            txtTelCidadao.Text = string.Empty;
            txtEmailCidadao.Text = string.Empty;
            cboxFamiliaCidadao.SelectedIndex = -1;
        }

        private void btnLimparCidadao_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

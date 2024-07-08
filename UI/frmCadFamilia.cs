using BLL;
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
    public partial class frmCadFamilia : Form
    {

        private FamiliaBLL familiaBLL = new FamiliaBLL();
        private List<Familia> familias = new List<Familia>();

        public frmCadFamilia()
        {
            InitializeComponent();
        }

        private void btnAplicarFamilia_Click(object sender, EventArgs e)
        {
            Familia familia = new Familia();

            if (!string.IsNullOrEmpty(txtID.Text))
                familia.Id = int.Parse(txtID.Text);

            familia.Sobrenome = txtSobrenomeFamilia.Text.Trim();
            familia.Responsavel = txtResFamilia.Text.Trim();

            if (string.IsNullOrWhiteSpace(familia.Sobrenome))
            {
                MessageBox.Show("Sobrenomes não pode ser vazio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(familia.Responsavel))
            {
                MessageBox.Show("Responsável não pode ser vazio.");
                return;
            }

            if (int.TryParse(txtPartFamilia.Text.Trim(), out int participantes))
            {
                familia.Participantes = participantes;
            }
            else
            {
                MessageBox.Show("Campo de participantes inválido. Insira apenas números.");
                return;
            }

            string retorno;

            // Inserir novo cidadão
            retorno = familiaBLL.CadastrarFamilia(familia);

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");
                btnLimparFamilia.PerformClick();
            }
        }

        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtSobrenomeFamilia.Text = string.Empty;
            txtResFamilia.Text = string.Empty;
            txtPartFamilia.Text = string.Empty;
        }

        private void btnLimparFamilia_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

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
using static UI.frmCadUser;

namespace UI
{
    public partial class frmAtendimentos : Form
    {

        private AtendimentoBLL atendimentoBLL;

        public frmAtendimentos()
        {
            InitializeComponent();
            atendimentoBLL = new AtendimentoBLL();
            txtObsAtend.TextChanged += txtObsAtend_TextChanged;
            CarregarNomesClientes();
            CarregarNomesColaboradores();
            UpdateCharCount();
        }

        public class AtendenteInvalidoException : Exception
        {
            public AtendenteInvalidoException(string message) : base(message)
            {
            }
        }

        private void txtObsAtend_TextChanged(object sender, EventArgs e)
        {
            UpdateCharCount();
        }

        private void UpdateCharCount()
        {
            int charCount = txtObsAtend.Text.Length;
            lblCharCount.Text = $"{charCount}/255";
            // Opcional: Mudar a cor do texto se exceder o limite
            if (charCount > 255)
            {
                lblCharCount.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblCharCount.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void CarregarNomesClientes()
        {
            List<string> nomesClientes = atendimentoBLL.ObterNomesClientes();
            cboxCidadaoAtend.DataSource = nomesClientes;

            cboxCidadaoAtend.SelectedIndex = -1;
        }

        private void CarregarNomesColaboradores()
        {
            List<string> nomesColaboradores = atendimentoBLL.ObterNomesColaboradores();
            cboxAtendente.DataSource = nomesColaboradores;

            cboxAtendente.SelectedIndex = -1;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (txtObsAtend.Text.Length > 255)
            {
                MessageBox.Show("O descritivo do atendimento não pode exceder 255 caracteres.");
                return;
            }

            txtObsAtend.MaxLength = 255;

            string codigo = txtCodigoAtend.Text;
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Código não pode ser vazio.");
                return;
            }

            DateTime dataAtendimento = dtDataAtend.Value;

            string statusAtendimento = cboxStatusAtend.Text;
            if (string.IsNullOrWhiteSpace(statusAtendimento))
            {
                MessageBox.Show("Status não pode ser vazio.");
                return;
            }

            int? idCliente = null;
            if (cboxCidadaoAtend.SelectedIndex != -1)
            {
                string nomeCliente = cboxCidadaoAtend.SelectedItem.ToString();
                idCliente = atendimentoBLL.ObterIdClientePorNome(nomeCliente);
            }

            int? idAtendente = null;
            if (cboxAtendente.SelectedIndex != -1)
            {
                string nomeColaborador = cboxAtendente.SelectedItem.ToString();

                // Validar se o nome do atendente não está vazio
                if (string.IsNullOrWhiteSpace(nomeColaborador))
                {
                    MessageBox.Show("Atendente não pode ser vazio.");
                    return;
                }

                try
                {
                    idAtendente = atendimentoBLL.ObterIdAtendente(nomeColaborador);
                }
                catch (AtendenteInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Atendente não pode ser vazio.");
                return;
            }

            string descritivo = txtObsAtend.Text;
            if (string.IsNullOrWhiteSpace(descritivo))
            {
                MessageBox.Show("Descritivo não pode ser vazio.");
                return;
            }

            Atendimento atendimento = new Atendimento
            {
                CodigoAtendimento = codigo,
                DataAtendimento = dataAtendimento,
                StatusAtendimento = statusAtendimento,
                IdCliente = idCliente,
                IdAtendente = idAtendente,
                DescritivoAtendimento = descritivo
            };

            if (!atendimento.DataAtendimento.HasValue)
            {
                MessageBox.Show("Data de atendimento não pode ser vazia.");
                return;
            }

            try
            {
                bool sucesso = atendimentoBLL.InserirAtendimento(atendimento);

                if (sucesso)
                {
                    MessageBox.Show("Atendimento inserido com sucesso!");
                    // Limpar campos ou atualizar interface
                }
                else
                {
                    MessageBox.Show("Falha ao inserir atendimento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }


        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtCodigoAtend.Text = string.Empty;
            dtDataAtend.Text = string.Empty;
            cboxStatusAtend.Text = string.Empty;
            cboxCidadaoAtend.Text = string.Empty;
            cboxAtendente.Text = string.Empty;
            txtObsAtend.Text = string.Empty;
        }

        private void btnLimparAtend_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}

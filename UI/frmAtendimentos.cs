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
    public partial class frmAtendimentos : Form
    {

        private AtendimentoBLL atendimentoBLL;

        public frmAtendimentos()
        {
            InitializeComponent();
            atendimentoBLL = new AtendimentoBLL();
            CarregarNomesClientes();
            CarregarNomesColaboradores();
        }

        private void CarregarNomesClientes()
        {
            List<string> nomesClientes = atendimentoBLL.ObterNomesClientes();
            cboxCidadaoAtend.DataSource = nomesClientes;
        }

        private void CarregarNomesColaboradores()
        {
            List<string> nomesColaboradores = atendimentoBLL.ObterNomesColaboradores();
            cboxAtendente.DataSource = nomesColaboradores;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoAtend.Text;
            DateTime dataAtendimento = dtDataAtend.Value;
            string statusAtendimento = cboxStatusAtend.SelectedItem.ToString();

            int? idCliente = null;
            if (cboxCidadaoAtend.SelectedIndex != -1)
            {
                string nomeCliente = cboxCidadaoAtend.SelectedItem.ToString();
                idCliente = atendimentoBLL.ObterIdClientePorNome(nomeCliente);
            }

            int idAtendente = 0;
            if (cboxAtendente.SelectedIndex != -1)
            {
                string nomeColaborador = cboxAtendente.SelectedItem.ToString();
                idAtendente = atendimentoBLL.ObterIdColaboradorPorNome(nomeColaborador);
            }

            Atendimento atendimento = new Atendimento
            {
                CodigoAtendimento = codigo,
                DataAtendimento = dataAtendimento,
                StatusAtendimento = statusAtendimento,
                IdCliente = idCliente,
                IdAtendente = idAtendente
            };

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
    }
}

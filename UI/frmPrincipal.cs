using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class frmPrincipal : Form
    {

        public int UserChamado { get; set; }
        public string User { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();

            int userChamado = Program.UserChamado;
            string user = Program.User;

            if (userChamado == 2)
            {
                // Código para administradores
                toolStripNovo.Enabled = true;
                toolStripCad.Enabled = true;
                toolStripEditarColab.Enabled = true;
            }
            else if (userChamado == 1)
            {
                // Código para Conselheiro
                toolStripNovo.Enabled = true;
                toolStripCad.Enabled = false;
                toolStripEditarColab.Enabled = false;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void toolStripPermissoes_Click(object sender, EventArgs e)
        {
            UI.frmPermissoes frmPermissoes = new frmPermissoes();
            frmPermissoes.ShowDialog();
        }

        private void toolStripGerar_Click(object sender, EventArgs e)
        {
            UI.frmGerarRelatorio frmGerarRelatorio = new UI.frmGerarRelatorio();
            frmGerarRelatorio.ShowDialog();
        }

        private void toolStripUser_Click(object sender, EventArgs e)
        {
            UI.frmCadUser frmCadUser = new UI.frmCadUser();
            frmCadUser.ShowDialog();
        }

        private void toolStripViewCadastros_Click(object sender, EventArgs e)
        {
            UI.frmVerCadastrados frmVerCadastrados = new UI.frmVerCadastrados();
            frmVerCadastrados.ShowDialog();
        }

        private void toolStripAtendimento_Click(object sender, EventArgs e)
        {
            UI.frmAtendimentos frmAtendimentos = new UI.frmAtendimentos();
            frmAtendimentos.ShowDialog();
        }

        private void toolStripCidadao_Click(object sender, EventArgs e)
        {
            UI.frmCadCidadao frmCadCidadao = new UI.frmCadCidadao();
            frmCadCidadao.ShowDialog();
        }

        private void toolStripFamilia_Click(object sender, EventArgs e)
        {
            UI.frmCadFamilia frmCadFamilia = new UI.frmCadFamilia();
            frmCadFamilia.ShowDialog();
        }

        private void toolStripViewAtend_Click(object sender, EventArgs e)
        {
            UI.frmVerAtendimentos frmVerAtendimentos = new UI.frmVerAtendimentos();
            frmVerAtendimentos.ShowDialog();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            // Esconder a tela principal
            this.Hide();

            // Abrir a tela de login de forma modal
            using (UI.frmLogin frmLogin = new UI.frmLogin())
            {
                if (frmLogin.ShowDialog() != DialogResult.OK)
                {
                    // Se o login não for bem-sucedido, fechar a aplicação
                    Application.Exit();
                }
                else
                {
                    // Se o login for bem-sucedido, mostrar a tela principal novamente
                    this.Show();
                }
            }
        }
    }
}

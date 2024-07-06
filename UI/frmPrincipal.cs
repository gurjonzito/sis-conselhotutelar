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
        public ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        public frmPrincipal()
        {
            InitializeComponent();
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

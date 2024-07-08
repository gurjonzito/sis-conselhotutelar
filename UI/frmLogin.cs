using System;
using System.Windows.Forms;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class frmLogin : Form
    {
        private LoginBLL loginBLL = new LoginBLL();

        public frmLogin()
        {
            InitializeComponent();
            loginBLL = new LoginBLL();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string senha = txtSenha.Text;

            // Validar o username
            string validarUser = loginBLL.ValidarUser(username);

            if (validarUser == "Email incorreto")
            {
                MessageBox.Show("Usuário incorreto.");
                return;
            }

            // Validar a senha
            string validarSenha = loginBLL.ValidarSenha(senha);

            if (validarSenha == "Senha incorreta")
            {
                MessageBox.Show("Senha incorreta.");
                return;
            }

            // Se ambos são válidos, login bem-sucedido
            MessageBox.Show("Sucesso ao entrar!");
            frmPrincipal telaPrincipal = new frmPrincipal();
            telaPrincipal.Closed += (s, args) => this.Close(); // Fecha o aplicativo quando a tela principal for fechada
            telaPrincipal.Show();

        }
    }
}
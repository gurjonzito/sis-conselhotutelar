using System;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmLogin : Form
    {
        private LoginBLL loginBLL = new LoginBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string senha = txtSenha.Text;

            Login login = new Login
            {
                Username = username,
                Senha = senha
            };

            bool isValid = loginBLL.ValidarUsuarioSenha(login);

            if (isValid)
            {
                MessageBox.Show("Sucesso ao entrar!");
                UI.frmPrincipal frmPrincipal = new UI.frmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
    }
}
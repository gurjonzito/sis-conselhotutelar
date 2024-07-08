using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using model;
using BLL;

namespace UI
{
    public partial class frmCadUser : Form
    {
        private UserBLL userBLL = new UserBLL();
        private List<Usuario> usuarios = new List<Usuario>();
        private Usuario usuarioLogado;

        public frmCadUser()
        {
            InitializeComponent();
        }

    public void SetUsuario(Usuario usuario)
        {
            usuarioLogado = usuario;
            if (usuario != null)
            {
                txtID.Text = usuario.id_usuario.ToString();
                txtNomeUser.Text = usuario.nome;
                txtUsernameUser.Text = usuario.usuario;
                txtEmailUser.Text = usuario.email;
                txtTelefoneUser.Text = usuario.telefone;
                cboxCargoUser.Text = usuario.id_cargo.ToString();
                txtSenhaUser.Enabled = false;
                txtConfirmSenhaUser.Enabled = false;
            }
        }

        Dictionary<string, int> niveisAcesso = new Dictionary<string, int>
        {
            { "Administrador", 2 },
            { "Conselheiro", 1 }
        };

        public int ObterIdCargo(string cargoTexto)
        {
            if (string.IsNullOrWhiteSpace(cargoTexto))
            {
                throw new CargoInvalidoException("Cargo não pode ser vazio.");
            }

            if (niveisAcesso.TryGetValue(cargoTexto, out int idCargo))
            {
                return idCargo;
            }
            else
            {
                throw new CargoInvalidoException("Cargo não reconhecido.");
            }
        }

        // Exceção personalizada para cargos inválidos
        public class CargoInvalidoException : Exception
        {
            public CargoInvalidoException(string message) : base(message)
            {
            }
        }


        private void btnAplicarUser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (!string.IsNullOrEmpty(txtID.Text))
                usuario.id_usuario = int.Parse(txtID.Text);

            usuario.nome = txtNomeUser.Text.Trim();
            usuario.usuario = txtUsernameUser.Text.Trim();
            usuario.email = txtEmailUser.Text.Trim();
            usuario.telefone = txtTelefoneUser.Text.Trim();
            


            if (string.IsNullOrWhiteSpace(usuario.nome))
            {
                MessageBox.Show("Nome não pode ser vazio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario.usuario))
            {
                MessageBox.Show("Usuário não pode ser vazio.");
                return;
            }

                if (string.IsNullOrWhiteSpace(usuario.email))
            {
                MessageBox.Show("E-mail não pode ser vazio.");
                return;
            }

            if (usuario.usuario.Contains(" "))
            {
                MessageBox.Show("Usuário não pode conter espaços em branco.");
                return;
            }

            if (usuario.email.Contains(" "))
            {
                MessageBox.Show("E-mail não pode conter espaços em branco.");
                return;
            }

            if (!UserBLL.IsValidEmail(usuario.email))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (string.IsNullOrWhiteSpace(txtSenhaUser.Text) || string.IsNullOrWhiteSpace(txtConfirmSenhaUser.Text))
                {
                    MessageBox.Show("Senha e confirmação de senha não podem ser vazias.");
                    return;
                }

                if (txtSenhaUser.Text != txtConfirmSenhaUser.Text)
                {
                    MessageBox.Show("As senhas não coincidem.");
                    return;
                }

                usuario.senha = BCrypt.Net.BCrypt.HashPassword(txtSenhaUser.Text);
            }

            try
            {
                usuario.id_cargo = ObterIdCargo(cboxCargoUser.Text.Trim());
            }
            catch (CargoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string retorno;

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                // Atualizar usuário
                retorno = userBLL.UpdateUsuario(usuario);
            }
            else
            {
                // Verificar se o usuário já existe
                if (userBLL.VerificarUsuario(usuario.usuario) == "Usuário existente")
                {
                    MessageBox.Show("O usuário já existe no banco de dados.");
                    return;
                }

                // Inserir novo usuário
                retorno = userBLL.CadastrarUsuario(usuario);
            }

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");
                btnLimparUser.PerformClick();
                txtSenhaUser.Enabled = true;
                txtConfirmSenhaUser.Enabled = true;
            }
        }

        private void btnLimparUser_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNomeUser.Text = string.Empty;
            txtUsernameUser.Text = string.Empty;
            txtEmailUser.Text = string.Empty;
            txtTelefoneUser.Text = string.Empty;
            txtSenhaUser.Text = string.Empty;
            txtConfirmSenhaUser.Text = string.Empty;
            cboxCargoUser.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

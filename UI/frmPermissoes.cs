using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmPermissoes : Form
    {
        private UserBLL usuarioBLL = new UserBLL();
        private PermissaoBLL permissaoBLL = new PermissaoBLL();

        public frmPermissoes()
        {
            InitializeComponent();
        }

        private void frmPermissoes_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarPermissoes();
        }

        private void CarregarUsuarios()
        {
            cboxUserPermissao.DataSource = usuarioBLL.GetUsuarios();
            cboxUserPermissao.DisplayMember = "Value";
            cboxUserPermissao.ValueMember = "Key";
        }

        private void CarregarPermissoes()
        {
            lstPermissaoExist.DataSource = permissaoBLL.ObterTodasPermissoes();
            lstPermissaoExist.DisplayMember = "Value";
            lstPermissaoExist.ValueMember = "Key";
        }

        private void cboxUserPermissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPermissoesUsuario(((KeyValuePair<int, string>)cboxUserPermissao.SelectedItem).Key);
        }

        private void CarregarPermissoesUsuario(int userId)
        {
            lstPermissaoUser.DataSource = permissaoBLL.ObterPermissoesUsuario(userId);
            lstPermissaoUser.DisplayMember = "Value";
            lstPermissaoUser.ValueMember = "Key";
        }

        private void btnAdicionarPermissao_Click(object sender, EventArgs e)
        {
            if (lstPermissaoExist.SelectedItem != null && cboxUserPermissao.SelectedItem != null)
            {
                var permissao = (KeyValuePair<int, string>)lstPermissaoExist.SelectedItem;
                var userId = ((KeyValuePair<int, string>)cboxUserPermissao.SelectedItem).Key;
                permissaoBLL.AtribuirPermissao(userId, permissao.Key);
                CarregarPermissoesUsuario(userId);
            }
        }

        private void btnRemoverPermissao_Click(object sender, EventArgs e)
        {
            if (lstPermissaoUser.SelectedItem != null && cboxUserPermissao.SelectedItem != null)
            {
                var permissao = (KeyValuePair<int, string>)lstPermissaoUser.SelectedItem;
                var userId = ((KeyValuePair<int, string>)cboxUserPermissao.SelectedItem).Key;
                permissaoBLL.RemoverPermissao(userId, permissao.Key);
                CarregarPermissoesUsuario(userId);
            }
        }
    }
}

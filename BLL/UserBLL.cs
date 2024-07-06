using System.Collections.Generic;
using System.Net.Mail;
using DAL;
using model;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        public string CadastrarUsuario(Usuario usuario)
        {
            userDAL.InserirUsuario(usuario); // Insere o novo usuário
            return "Sucesso";
        }

        public string VerificarUsuario(string usuario)
        {
            bool userExists = userDAL.VerificarUser(usuario);

            return userExists ? "Usuário existente" : "Usuário não existe";
        }

        public string VerificarEmail(string email)
        {
            bool emailExists = userDAL.VerificarEmail(email);

            return emailExists ? "E-mail existente" : "E-mail não existe";
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool VerificarCredenciais(string usuario, string senha)
        {
            Usuario user = userDAL.ObterUsuario(usuario);

            if (user != null)
            {
                string senhaCriptografadaDoBanco = user.Senha;

                if (senhaCriptografadaDoBanco != null)
                {
                    // Verificar a senha
                    if (BCrypt.Net.BCrypt.Verify(senha, senhaCriptografadaDoBanco))
                    {
                        return true; // Credenciais válidas
                    }
                }
            }

            return false; // Credenciais inválidas
        }

        public string UpdateUsuario(Usuario usuario)
        {
            userDAL.AtualizarUsuario(usuario);
            return "Sucesso";
        }

        public int ObterUserChamado(string usuario)
        {
            return userDAL.ObterUserChamado(usuario);
        }

        public List<Usuario> GetUsuarios()
        {
            return userDAL.GetUsuarios();
        }
    }
}

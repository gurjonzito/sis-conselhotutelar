using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;

namespace BLL
{
    public class LoginBLL
    {
        public string ValidarUser(string validarUser)
        {
            LoginDAL loginDAL = new LoginDAL();
            bool userExists = loginDAL.ValidarUserLogin(validarUser);

            if (userExists)
            {
                return "Email correto";
            }
            else
            {
                return "Email incorreto";
            }
        }
        public string ValidarSenha(string validarSenha)
        {

            LoginDAL loginDAL = new LoginDAL();
            bool senhaExists = loginDAL.ValidarSenhaLogin(validarSenha);

            if (senhaExists)
            {
                return "Senha correta";
            }
            else
            {
                return "Senha incorreta";
            }
        }

        public int ObterTipoUsuario(string username)
        {
            LoginDAL loginDAL = new LoginDAL();
            return loginDAL.ObterTipoUsuario(username);
        }
    }
}

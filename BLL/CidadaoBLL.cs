using System.Collections.Generic;
using System.Net.Mail;
using DAL;
using model;

namespace BLL
{
    public class CidadaoBLL
    {
        private CidadaoDAL cidadaoDAL = new CidadaoDAL();

        public string CadastrarCidadao(Cidadao cidadao)
        {
            cidadaoDAL.InserirCidadao(cidadao); // Insere o novo usuário
            return "Sucesso";
        }

        public string VerificarCidadao(int idCidadao)
        {
            bool userExists = cidadaoDAL.VerificarCidadao(idCidadao);

            return userExists ? "Cidadão existente" : "Cidadão não existe";
        }

        public string VerificarEmail(string email)
        {
            bool emailExists = cidadaoDAL.VerificarEmail(email);

            return emailExists ? "E-mail existente" : "E-mail não existe";
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return true; // Aceita e-mails nulos
            }

            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true; // E-mail válido
            }
            catch (FormatException)
            {
                return false; // E-mail inválido
            }
        }

        public int ObterIdFamiliaPorNome(string nomeFamilia)
        {
            return cidadaoDAL.ObterIdFamiliaPorNome(nomeFamilia);
        }

        public string UpdateCidadao(Cidadao cidadao)
        {
            cidadaoDAL.AtualizarCidadao(cidadao);
            return "Sucesso";
        }

        public List<Cidadao> GetCidadaos()
        {
            return cidadaoDAL.GetCidadaos();
        }
    }
}

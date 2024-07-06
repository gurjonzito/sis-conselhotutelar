using DAL;
using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColaboradorBLL
    {
        ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
        public string CadColab(Colaborador colaborador, string emailUsuarioLogado)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            colaboradorDAL.InserirColaborador(colaborador, emailUsuarioLogado);
            return "Sucesso";
        }
        public string VerificarEmail(string verifemail)
        {
            bool emailExists = colaboradorDAL.VerificarEmailColaborador(verifemail);

            if (emailExists)
            {
                return "Email existente";
            }
            else
            {
                return "Email não existe";
            }
        }
        /*public string UpdateColaborador(Colaborador colaborador)
        {
            colaboradorDAL.UpdateColaborador(colaborador);

            return "Sucesso";
        }*/

        public string VerificarNome(string verifnome)
        {

            bool nomeExists = colaboradorDAL.VerificarNome(verifnome);

            if (nomeExists)
            {
                return "Nome existente";
            }
            else
            {
                return "Nome não existe";
            }
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /*public int ObterIdColaboradorPorNome(string nomeColaborador)
        {
            return colaboradorDAL.ObterIdColaboradorPorNome(nomeColaborador);
        }*/

        public Colaborador ObterColaboradorPorID(int idColaborador)
        {

            return colaboradorDAL.ObterColaboradorPorID(idColaborador);
        }

        public List<Colaborador> GetColaboradoresAtivosComSetor()
        {
            return colaboradorDAL.GetColaboradoresAtivosComSetor();
        }

        public DataTable CarregarColaborador()
        {
            DataTable dt = colaboradorDAL.ConsultarColaborador();
            return dt;
        }
    }
}

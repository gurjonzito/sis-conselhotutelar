using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AtendimentoBLL
    {
        private AtendimentoDAL atendimentoDAL = new AtendimentoDAL();
        public string CadEquip(Atendimento atendimento, string emailUsuarioLogado)
        {
            AtendimentoDAL atendimentoDAL = new AtendimentoDAL();

            atendimentoDAL.InserirAtendimento(atendimento, emailUsuarioLogado);

            return "Sucesso";
        }

        public string VerificarCodigo(string verifcodigo)
        {
            AtendimentoDAL atendimentoDAL = new AtendimentoDAL();
            bool codigoExists = atendimentoDAL.VerificarCodigo(verifcodigo);

            if (codigoExists)
            {
                return "Código existente";
            }
            else
            {
                return "Código não existe";
            }
           
        }

        public List<Atendimento> GetAtendimentos()
        {

            return atendimentoDAL.GetAtendimentos();
        }

        public List<Atendimento> ObterAtendimentos()
        {
           return atendimentoDAL.GetAtendimentosRelatorio();
        }
        public List<Atendimento> ObterAtendimentosPorColaborador(int idColaborador)
        {
            return atendimentoDAL.ObterAtendimentosPorColaborador(idColaborador);
        }
    }
}

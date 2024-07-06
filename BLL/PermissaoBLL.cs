using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class PermissaoBLL
    {
        private PermissaoDAL permissaoDAL = new PermissaoDAL();

        public List<KeyValuePair<int, string>> ObterTodasPermissoes()
        {
            return permissaoDAL.ObterTodasPermissoes();
        }

        public List<KeyValuePair<int, string>> ObterPermissoesUsuario(int userId)
        {
            return permissaoDAL.ObterPermissoesUsuario(userId);
        }

        public void AtribuirPermissao(int userId, int permissaoId)
        {
            permissaoDAL.AtribuirPermissao(userId, permissaoId);
        }

        public void RemoverPermissao(int userId, int permissaoId)
        {
            permissaoDAL.RemoverPermissao(userId, permissaoId);
        }
    }
}

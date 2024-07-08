using System.Collections.Generic;
using DAL;
using model;

namespace BLL
{
    public class FamiliaBLL
    {
        private FamiliaDAL familiaDAL = new FamiliaDAL();

        public string CadastrarFamilia(Familia familia)
        {
            familiaDAL.InserirFamilia(familia); // Insere a nova família
            return "Sucesso";
        }

        public List<Familia> ObterFamilias()
        {
            return familiaDAL.ObterFamilias();
        }

        public Familia ObterFamiliaPorID(int idFamilia)
        {

            return familiaDAL.ObterFamiliaPorID(idFamilia);
        }
    }
}

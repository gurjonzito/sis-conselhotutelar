using System.ComponentModel.DataAnnotations;

namespace model
{
    public class Cidadao
    {
        public string emailCidadao;
        public string nomeCidadao;
        public string telefoneCidadao;
        public int IdCidadao { get; set; }
        public int IdadeCidadao { get; set; }
        public int? IdFamiliaCidadao { get; set; }


        public string NomeCidadao
        {
            get { return nomeCidadao; }
            set { nomeCidadao = value; }
        }

        public string TelefoneCidadao
        {
            get { return telefoneCidadao; }
            set { telefoneCidadao = value; }
        }

        [EmailAddress]
        public string EmailCidadao
        {
            get { return emailCidadao; }
            set { emailCidadao = value; }
        }
    }
}

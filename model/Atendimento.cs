using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Atendimento
    {
        public int idAtendimento;
        public string codigo { get; set; }
        public int dataAtendimento { get; set; }
        public string statusAtendimento { get; set; }
        public string idCliente { get; set; }
        public string idAtendente { get; set; }


        public int IdAtendimento
        {
            get { return idAtendimento; }
            set { idAtendimento = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int DataAtendimento
        {
            get { return dataAtendimento; }
            set { dataAtendimento = value; }
        }

        public string StatusAtendimento
        {
            get { return statusAtendimento; }
            set { statusAtendimento = value; }
        }
    }
}

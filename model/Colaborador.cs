using System.ComponentModel.DataAnnotations;

namespace model
{
    public class Colaborador
    {
        public int IdColaborador { get; set; }
        string emailColaborador;
        string nomeColaborador { get; set; }
        string senhaColaborador;
        string telefoneColaborador;
        public int IdCargo { get; set; }
        public string SenhaHash { get; set; }
        public string NomeCargo { get; set; } // Adicione esta linha

        public string NomeColaborador
        {
            get { return nomeColaborador; }
            set { nomeColaborador = value; }
        }

        public string TelefoneColaborador
        {
            get { return telefoneColaborador; }
            set { telefoneColaborador = value; }
        }

        [EmailAddress]
        public string EmailColaborador
        {
            get { return emailColaborador; }
            set { emailColaborador = value; }
        }
        public string SenhaColaborador
        {
            get { return senhaColaborador; }
            set { senhaColaborador = value; }
        }
    }
}

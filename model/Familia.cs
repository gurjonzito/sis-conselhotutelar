namespace model
{
    public class Familia
    {
        public int Id { get; set; }
        public string Sobrenome { get; set; }
        public string Responsavel { get; set; }
        public int Participantes { get; set; }
        public string NomeFamilia { get; set; } // Adicionando propriedade para o nome da família
    }
}

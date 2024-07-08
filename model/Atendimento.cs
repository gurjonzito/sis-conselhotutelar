public class Atendimento
{
    public int IdAtendimento { get; set; }
    public string CodigoAtendimento { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string StatusAtendimento { get; set; }
    public int? IdCliente { get; set; }
    public int? IdAtendente { get; set; }
}

public class AtendimentoBLL
{
    private AtendimentoDAL atendimentoDAL;

    public AtendimentoBLL()
    {
        atendimentoDAL = new AtendimentoDAL();
    }

    public bool InserirAtendimento(Atendimento atendimento)
    {
        // Validações
        if (string.IsNullOrEmpty(atendimento.CodigoAtendimento) || atendimento.CodigoAtendimento.Length > 10)
        {
            throw new ArgumentException("O código do atendimento é inválido.");
        }

        if (atendimento.DataAtendimento == default(DateTime))
        {
            throw new ArgumentException("A data do atendimento é inválida.");
        }

        if (string.IsNullOrEmpty(atendimento.StatusAtendimento) ||
    !(atendimento.StatusAtendimento.Equals("Ativo", StringComparison.OrdinalIgnoreCase) ||
      atendimento.StatusAtendimento.Equals("Inativo", StringComparison.OrdinalIgnoreCase)))
        {
            throw new ArgumentException("O status do atendimento é inválido.");
        }


        if (atendimento.IdAtendente <= 0)
        {
            throw new ArgumentException("O ID do atendente é inválido.");
        }

        return atendimentoDAL.InserirAtendimento(atendimento);
    }

    public List<string> ObterNomesClientes()
    {
        return atendimentoDAL.ObterNomesClientes();
    }

    public List<string> ObterNomesColaboradores()
    {
        return atendimentoDAL.ObterNomesColaboradores();
    }

    public int ObterIdClientePorNome(string nomeCliente)
    {
        return atendimentoDAL.ObterIdClientePorNome(nomeCliente);
    }

    public int ObterIdColaboradorPorNome(string nomeColaborador)
    {
        return atendimentoDAL.ObterIdColaboradorPorNome(nomeColaborador);
    }


    public List<Atendimento> ObterAtendimentosPorColaborador(int idColaborador)
    {
        return atendimentoDAL.ObterAtendimentosPorColaborador(idColaborador);
    }


}

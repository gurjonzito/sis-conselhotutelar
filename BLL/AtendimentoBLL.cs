using BLL;
using DAL;
using model;

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

        if (atendimento.IdCliente <= 0)
        {
            throw new ArgumentException("O ID do cidadão é inválido.");
        }

        return atendimentoDAL.InserirAtendimento(atendimento);
    }

    public class AtendenteInvalidoException : Exception
    {
        public AtendenteInvalidoException(string message) : base(message)
        {
        }
    }

    public int ObterIdAtendente(string atendenteTexto)
    {
        if (string.IsNullOrWhiteSpace(atendenteTexto))
        {
            throw new AtendenteInvalidoException("Nome do atendente não pode ser vazio.");
        }

        try
        {
            return atendimentoDAL.ObterIdColaboradorPorNome(atendenteTexto);
        }
        catch (Exception ex)
        {
            throw new AtendenteInvalidoException("Erro ao obter ID do atendente: " + ex.Message);
        }
    }

    public List<Atendimento> GetAtendimentosComNomesPorColaborador(int idColaborador)
    {
        List<Atendimento> atendimentos = new List<Atendimento>();

        try
        {
            // Obter os atendimentos com os nomes dos colaboradores associados
            atendimentos = atendimentoDAL.GetAtendimentosComNomesPorColaborador(idColaborador);
        }
        catch (Exception ex)
        {
            // Tratar exceções ou lançar novamente conforme necessário
            throw new Exception("Erro ao obter os atendimentos com nomes de colaboradores: " + ex.Message);
        }

        return atendimentos;
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

    public Atendimento ObterAtendimentoPorCodigo(string codigoAtendimento)
    {
        return atendimentoDAL.ObterAtendimentoPorCodigo(codigoAtendimento);
    }

    public List<Atendimento> ObterAtendimentosPorColaborador(int idColaborador)
    {
        return atendimentoDAL.ObterAtendimentosPorColaborador(idColaborador);
    }

    public List<Atendimento> GetAtendimentosComNomes()
    {
        return atendimentoDAL.GetAtendimentosComNomes();
    }

    public List<Atendimento> GetAtendimentos()
    {
        return atendimentoDAL.GetAtendimentos();
    }
}

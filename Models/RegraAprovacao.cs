// default Strategy for approval rules

public interface IRegraAprovacao
{
    bool PodeAprovar(OperacaoCredito operacao);
}

public class RegraAprovacao : IRegraAprovacao
{
    public bool PodeAprovar(OperacaoCredito operacao)
    {
        return operacao.Cliente != null && 
        operacao.Valor <= operacao.Cliente?.LimiteCredito;
    }
}

public class RegraAprovacaoScore : IRegraAprovacao
{
    public bool PodeAprovar(OperacaoCredito operacao)
    {
        return operacao.ScoreRisco >= 700; // Example: Approve if risk score is 700 or higher
    }
}

public class RegraAprovacaoFactory
{
    public static IRegraAprovacao CriarRegra()
    {
        return new RegraAprovacao(); // Default rule based on credit limit
    }
}

public class ContratoService
{
    public string GerarContrato(OperacaoCredito op)
    {
        return $@"
CONTRATO DE CRÉDITO
Cliente: {op.Cliente?.Nome}
Valor: R$ {op.Valor}
Prazo: {op.Meses} meses
Score Risco: {op.ScoreRisco}
Status: {op.Status}
Data: {DateTime.Now:dd/MM/yyyy}
        ";
    }
}
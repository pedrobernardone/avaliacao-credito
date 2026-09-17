using Xunit;
using Services;
public class OperacaoCreditsTest
{
    [Fact]
    public async Task DeveAprovarQuandoLimiteSuficiente()
    {
        var ctx = new CreditoDbContext();
        var cliente = new Cliente {Nome = "Teste", CPF = "99999999999", LimiteCredito = 1000};
        ctx.Clientes.Add(cliente);
        ctx.Operacoes.Add(new OperacaoCredito 
        {
            ClienteId = cliente.Id, 
            Valor = 500
        });
        ctx.SaveChanges();

        var service = new ScoreRiscoService();
        var score = await service.ObterScoreRisco(500, cliente.CPF);
        
        var op = new OperacaoCredito
        {
            Cliente = cliente, Valor = 500, ScoreRisco = score };
            var regra = RegraAprovacaoFactory.CriarRegra();
            bool aprovado = regra.PodeAprovar(op);

            Assert.True(aprovado);
        }
}
public static class DbSeeds
{
    public static void Seed(CreditoDbContext context)
    {
        if (!context.Clientes.Any())
        {
            context.Clientes.Add(new Cliente {Nome = "Pedro Henrique Rodrigues", CPF = "12345678900", LimiteCredito = 10000});
        }
    }
}
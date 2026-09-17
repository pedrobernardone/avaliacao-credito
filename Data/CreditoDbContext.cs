using Microsoft.EntityFrameworkCore;
public class CreditoDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<OperacaoCredito> Operacoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=CreditoDb.db");
    }
}   
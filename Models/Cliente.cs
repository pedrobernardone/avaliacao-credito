public class Cliente
{
    public int Id { get; set; }  // Client ID
    public string Nome { get; set; } = string.Empty; // Client name
    public string CPF { get; set; } = string.Empty; // Client CPF (Brazilian individual taxpayer registry identification)
    public decimal LimiteCredito { get; set; } = 0; // Credit limit for the client and it starts with 0 by default
    public DateTime DataCadastro { get; set; } = DateTime.Now; // Data of client registration
}
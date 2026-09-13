public class OperacaoCredito
{
    public int Id { get; set; }
    public int ClientId { get; set; } // Foreign key to Cliente
    public decimal Valor { get; set; } = 0; // Amount of the credit operation
    public int Meses { get; set; } = 0; // Number of months for the credit operation
    public decimal ScoreRisco { get; set; } = 0; // Risk score for the credit operation
    public DateTime DataSolicitacao { get; set; } = DateTime.Now; // Date of the credit operation request
    public string Status { get; set; } = "Pendente"; // Status of the credit operation (e.g., Approved, Rejected, Pending)
    public Cliente? Cliente { get; set; } // Navigation property to Cliente
}
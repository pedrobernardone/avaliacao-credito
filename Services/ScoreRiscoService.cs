using System.Net.Http;
using System.Net.Http.Json;

namespace Services;

public class ScoreRiscoService
{
    private readonly HttpClient _httpClient;

    public ScoreRiscoService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:5000/")
        };
    }

    public async Task<decimal> ObterScoreRisco(decimal valor, string cpf)
    {
        var payload = new { valor, cpf };
        var response = await _httpClient.PostAsJsonAsync("/score", payload);

        if (!response.IsSuccessStatusCode)
        {
            return 500;
        }

        var result = await response.Content.ReadFromJsonAsync<ScoreRiscoResponse>();
        return result?.Score ?? 500;
    }
}

public class ScoreRiscoResponse
{
    public decimal Score { get; set; }
}
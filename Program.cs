var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/status", () => "✅ Sistema de Crédito rodando!");

app.Run();
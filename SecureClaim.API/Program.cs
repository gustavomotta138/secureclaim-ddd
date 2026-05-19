var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/sinistro", () => new
{
    id = 1,
    descricao = "Colisão frontal",
    status = "ABERTO"
});

app.MapGet("/api/apolice/validar", () => new
{
    apoliceId = 1,
    status = "ATIVA",
    coberturaValida = true,
    mensagem = "Apólice ativa e cobertura válida para o sinistro."
});

app.MapGet("/api/indenizacao/calcular", () => new
{
    valorDano = 10000,
    franquia = 2000,
    valorIndenizacao = 8000,
    mensagem = "Indenização calculada aplicando a franquia da apólice."
});

app.Run();
using Models;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ImcService>();

var app = builder.Build();

app.MapPost("/imc", (ImcRequest req, ImcService service) =>
{
    var imc = service.Calcular(req.Peso, req.Altura);
    return Results.Ok(new { imc });
});

app.Run();
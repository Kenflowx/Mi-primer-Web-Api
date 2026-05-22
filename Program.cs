var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Bienvenido a mi primera Web API con ASP.NET Core! Práctica 1.");

app.MapGet("/kenovit-garcia", () =>
{
    var estudiante = new Dictionary<string, string>
    {
        { "Nombre", "Kenovit" },
        { "Apellido", "Garcia" },
        { "Matricula", "Lr-2024-00841" },
        { "Asignatura", "Lenguaje de Programación III" }
    };

    return Results.Ok(estudiante);
});

app.Run();

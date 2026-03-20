using ApiSimples;

var builder = WebApplication.CreateBuilder(args);

// registrar controllers
builder.Services.AddControllers();

// registrar service
builder.Services.AddScoped<PessoaService>();

var app = builder.Build();

// mapear controllers
app.MapControllers();

app.Run();
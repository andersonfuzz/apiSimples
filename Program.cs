var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("TarefaDb"));
builder.Services.AddScoped<ICustomerService, TarefaService>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();
var app = builder.Build();
app.MapOpenApi();
app.MapControllers();
app.Run();



/*
using Captain.Data;
using Captain.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("CustomerDb"));
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
// app.UseHttpsRedirection();
app.MapControllers();
app.Run();
*/
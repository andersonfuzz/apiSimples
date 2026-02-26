using Microsoft.EntityFrameworkCore;
using apiSimples.Model;

namespace apiSimples.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoas => Set<Pessoa>();
}

/*
O DbContext é a classe que representa a conexão 
com o banco de dados.
 O DbSet<Pessoa> é a "tabela" de pessoas.
*/
namespace apiSimples.Data;

public class AppDbCOntext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Tarefa>Tarefas => Set<Tarefa>();
}
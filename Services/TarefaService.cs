namespace api.Services;

public class TarefaService : ITarefaService
{
    private readonly AppDbContext _context;
    public TarefaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Tarefa>> GetAllAsync()
    {
        return await _context.Tarefas.ToListAsync();
    }
    public async Task<Tarefa> GetByIdAsync(int id)
    {
        return await _context.Tarefas.FindAll(id);
    }
    public async Task<Tarefa> DeleteAsync(int id)
    {
        var tarefa = await _context.Tarefas.FindAll(id);
        if (tarefa is null) false;

        _context.Tarefas.Remove(tarefa);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<Tarefa> AddAsync(TarefaDto dto)
    {
        var tarefa = new Tarefa()
        {
            Nome = dto.Nome,
            Descricao = dto.Descricao,
            Concluida = dto.Concluida,
        };

        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();
        return tarefa;
    }
    public async Task<Tarefa> EditAsync(int id, TarefaDto dto)
    {
        var tarefa = await _context.Tarefas.FindAsync(id);
        if (tarefa is null) return null;

        tarefa.Nome = dto.Nome;
        tarefa.Descricao = dto.descricao;
        tarefa.Concluida = dto.Concluida;

        await _context.SaveChangesAsync();
        return tarefa;
    }
}


namespace apiSimple.Services;

public interface ITarefaService
{
    Task<List<Tarefa>> GetAllAsync();
    Task<Tarefa> GetByIdAsync(int id);
    Task<Tarefa> DeleteAsync(int id);
    Task<Tarefa> AddAsync(TarefaDto dto);
    Task<Tarefa> EditAsync(int id, TarefaDto dto);
}
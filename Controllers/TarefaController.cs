using apiSimples.Models.Customers;
using apiSimples.Services;
using Microsoft.AspNetCore.Mvc;

namespace Captain.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TarefaController : ControllerBase
{
    private readonly ICustomerService _service;
    public TarefaController(ICustomerService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var tarefas = await _service.GetAllAsync();
        return Ok(tarefas);
    }
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(int id)
    {
        var tarefa = await _service.GetByIdAsync(id);
        if (tarefa is null)
            return NotFound(new { mensagem = $"Tarefa com Id {id} não encontrada." });

        return Ok(tarefa);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteByIdAsync(id);
        if (!deleted)
            return NotFound(new { mensagem = $"Tarefa com Id {id} não encontrada" });
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Edit(int id, [FromBody] TarefaDto dto)
    {
        var tarefa = await _service.EditAsync(id, dto);
        if (tarefa is null)
            return NotFound(new { mensagem = $"Tarefa com Id {id} não encontrada" });
        return Ok(tarefa);
    }
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] TarefaDto dto)
    {
        var tarefa = await _service.AddAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = tarefa.Id }, tarefa);
    }



}
using System.ComponentModel.DataAnnotations;

namespace apiSimples.Models;

public class TarefaDto
{
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string Descricao { get; set; } = string.Empty;
    public bool Concluida { get; set; }
}
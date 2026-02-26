using System.ComponentModel.DataAnnotations;
namespace apiSimples.Model;

public class PessoaDto
{
    [Required(ErrorMessage ="O nome é obrigatório")]
     public string Nome{get;set;}=string.Empty;
    [Required(ErrorMessage ="A cidade é obrigatória")]
     public string Cidade{get;set;}=string.Empty;
}

/*
O Dto é o objeto que recebe os dados do usuário nas 
requisições. Ele não tem o Id pois quem define o Id 
é o banco, não o usuário.*/
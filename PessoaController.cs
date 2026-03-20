using Microsoft.AspNetCore.Mvc;

namespace ApiSimples;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    private readonly PessoaService _service;

    public PessoaController(PessoaService service)
    {
        _service = service;
    }

   
    [HttpPost]
    public ActionResult<BuscarPessoaDto> CriarPessoa(CriarPessoaDto dto)
    {
        var pessoa = _service.CriarPessoa(dto);
        var response = new BuscarPessoaDto(pessoa.Id, pessoa.Nome, pessoa.Idade, pessoa.Menssagem);
        return CreatedAtAction(nameof(CriarPessoa), response);
    }



}
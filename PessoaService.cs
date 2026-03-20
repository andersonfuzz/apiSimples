namespace ApiSimples;

public class PessoaService
{
    public Pessoa CriarPessoa(CriarPessoaDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);
        var pessoa = new Pessoa(dto.Nome, dto.Idade, dto.Menssagem);
        return pessoa;
    }
}
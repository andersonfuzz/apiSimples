namespace ApiSimples;
    public record CriarPessoaDto(string Nome, int Idade, string Menssagem);
    public record EditarPessoaDto(string Nome, int Idade, string Menssagem);
    public record BuscarPessoaDto(Guid Id, string Nome, int Idade, string Menssagem);


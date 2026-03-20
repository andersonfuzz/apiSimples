namespace ApiSimples;
public class Pessoa{

    public Guid Id{get;private set;}=Guid.NewGuid();
    public string Nome{get;private set;}
    public int Idade{get;private set;}
    public string Menssagem{get;private set;}

    public Pessoa(string nome, int idade, string menssagem)
    {
        Nome = nome;
        Idade = idade;
        Menssagem = menssagem;
    }
    
    public void Atualizar(string nome, int idade, string menssagem)
    {
        Nome = nome;
        Idade = idade;
        Menssagem = menssagem;
    }
    
}
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Paulo", 28, "Masculino", "Sim");
        System.Console.WriteLine(aluno.Nome);
        System.Console.WriteLine(aluno.Idade);
        System.Console.WriteLine(aluno.Sexo);
        System.Console.WriteLine(aluno.Aprovado);
    }
}

public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome; '
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    // Atributos
    public string? Nome { get; set; } 
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Aprovado { get; set; }
}

Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 25;
p1.Sexo = "Feminino";  

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Idade = 30;
p2.Sexo = "Masculino";

Pessoa p3 = new Pessoa();
p3.Nome = "Ana";
p3.Idade = 22;
p3.Sexo = "Feminino";

Console.WriteLine($"{p1.Nome}, {p1.Idade}, {p1.Sexo}");
Console.WriteLine($"{p2.Nome}, {p2.Idade}, {p2.Sexo}");
Console.WriteLine($"{p3.Nome}, {p3.Idade}, {p3.Sexo}");

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}

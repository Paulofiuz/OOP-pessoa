using System;

namespace Principal
{
    public class Produto
    {
        // Definindo propriedade - prop

        private string? nome; // Campo de apoio
        public string? Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value < 5.00)
                {
                    preco = 5.00;
                }
                else
                {
                    preco = value;
                }
            }
        }
        private double desconto = 0.05;
        public double Desconto
        {
            get { return desconto; } // Somente leitura
        }
        public double PrecoFinal
        {
            get { return Preco - (Preco * Desconto); }
        }
        private int minimo;
        public int EstoqueMinimo
        {
            set { minimo = value; }
        }

        // Método para exibir os detalhes do produto
        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} \nPreço: {Preco.ToString("c")} \nDesconto: {Desconto} \nPreço final: {PrecoFinal.ToString("c")} \nEstoque: {minimo}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Instância do produto
            Produto produto = new Produto();

            // Atribuindo valores
            produto.Nome = "Notebook";
            produto.Preco = 1500.00;
            produto.EstoqueMinimo = 10;

            // Exibindo detalhes do produto
            produto.Exibir();
        }
    }
}

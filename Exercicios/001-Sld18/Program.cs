using System;
using System.Globalization;

namespace _001_Sld18
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod1 = "Computador";
            string prod2 = "Mesa";
            string moeda = "R$";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("\nProdutos:");
            Console.WriteLine($"{prod1}, cujo o preço é {moeda} {preco1:F2}");
            Console.WriteLine($"{prod2}, cujo o preço é {moeda} {preco2:F2}");

            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando para 2 casas decimais {medida:F2}");
            Console.WriteLine("Utilizando o invariant culture " + medida.ToString("F2",CultureInfo.InvariantCulture)+"\n");
            
        }
    }
}

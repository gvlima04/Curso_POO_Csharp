using System;
using System.Globalization;

namespace _002_Sld23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Número da casa:");
            int numQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da conta de energia:");
            double valEnergia = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu último nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');

            string lastName = dados[0];
            int idade = int.Parse(dados[1]);
            double alt = double.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(valEnergia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(alt.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

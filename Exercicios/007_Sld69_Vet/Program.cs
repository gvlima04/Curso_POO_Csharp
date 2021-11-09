using System;

namespace _007_Sld69_Vet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número de inserções:");
            int num = int.Parse(Console.ReadLine());

            double[] alturas = new double[num];

            for (int i = 0; i < alturas.Length; i++)
            {
                System.Console.Write("Altura " + (i+1) + ": ");
                alturas[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0.0;

            for (int i = 0; i < alturas.Length; i++)
            {
                soma += alturas[i];
            }

            double media = soma/num;

            System.Console.WriteLine("A média das alturas é: " + media.ToString("F2"));
        }
    }
}

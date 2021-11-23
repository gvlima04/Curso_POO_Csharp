using System;
using Generics.Entities;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Dados do produto {i}: ");
                string[] prodData = Console.ReadLine().Split(',');
                
                list.Add(new Product(prodData[0], int.Parse(prodData[1])));  

            }

            Console.WriteLine("Max: ");
            Console.WriteLine(CalculationService.Max<Product>(list));

        }
    }
}

using System;
using System.Threading;

namespace _006_Sld60_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cc;
            int menu = -1;

            Console.WriteLine("Digite o número da conta:");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular:");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Deseja fazer um depósito inicial(s/n)?");
            char depInicial = char.Parse(Console.ReadLine());

            if (depInicial == 'n' || depInicial == 'N')
            {
                cc = new ContaBancaria(numConta,nomeTitular);
            } else
            {   
                Console.WriteLine("Valor a ser depositado:");
                double valDep = double.Parse(Console.ReadLine());
                cc = new ContaBancaria(numConta, nomeTitular, valDep);
            }

            Console.WriteLine("\n\nDados da Conta:");
            Console.WriteLine(cc);
            Thread.Sleep(2500);
            
            while (menu != 0)
            {
                Console.WriteLine("\n\nDigite: ");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Dados da conta");
                Console.WriteLine("0 - Sair");
                menu = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                switch (menu)
                {
                    case 1:
                        Console.Write("Valor a ser depositado: R$");
                        double valDep = double.Parse(Console.ReadLine());
                        cc.Deposito(valDep);
                        break;

                    case 2:
                        Console.Write("Valor a ser sacado: R$");
                        double valSaq = double.Parse(Console.ReadLine());
                        cc.Saque(valSaq);
                        break;
                    
                    case 3:
                        Console.WriteLine(cc);
                        break;

                    case 0:
                        break;
                }

                if (menu != 0)
                {
                    Thread.Sleep(2500);
                }               
            }
        }
    }
}

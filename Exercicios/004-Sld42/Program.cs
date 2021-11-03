using System;
using System.Threading;

namespace _004_Sld42
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod1 = new Produto();
            int menu = -1;

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            prod1.nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod1.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            prod1.quantidade = int.Parse(Console.ReadLine());

            double valTotal = prod1.ValEstoque();

            Console.WriteLine("\nDados do Produto: " + prod1);
            Thread.Sleep(3000);

            while (menu != 0)
            {
                Console.WriteLine("\nDigite: \n1 - para adicionar produtos aos estoque; \n2 - para retirar produtos do estoque; \n3 - para consultar o valor total em estoque; \n4 - Para imprimir os dados do produto; \n0 - sair.");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("Informe a quantidade para ser adicionada ao estoque:");
                        int qtdIN = int.Parse(Console.ReadLine());
                        prod1.AddEstoque(qtdIN);
                        break;

                    case 2:
                        Console.WriteLine("Informe a quantidade para ser retirada do estoque:");
                        int qtdOUT = int.Parse(Console.ReadLine());
                        prod1.SubEstoque(qtdOUT);
                        break;

                    case 3:
                        Console.WriteLine("O valor total em estoque: " + prod1.ValEstoque().ToString("F2"));
                        break;

                    case 4:
                        Console.WriteLine("Dados do Produto: " + prod1);
                        break;

                    default:
                        Console.WriteLine("As opções disponíveis são 1, 2, 3, e 0.");
                        break;
                }
                if (menu!=0)
                {
                    Thread.Sleep(3000);
                }
                

            }

        }
    }
}

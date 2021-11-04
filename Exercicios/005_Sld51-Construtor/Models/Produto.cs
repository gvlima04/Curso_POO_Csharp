using System;

namespace _005_Sld51_Construtor
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco)
        { //Construtor 
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto()
        { //Construtor padrão
        }

        public double ValEstoque()
        {
            return Quantidade * Preco;
        }

        public void AddEstoque(int qtd)
        {
            Quantidade += qtd;
            Console.WriteLine(qtd + " Unidade(s) adicionadas ao estoque.");
        }

        public void SubEstoque(int qtd)
        {
            if (Quantidade >= qtd)
            {
                Quantidade -= qtd;
                Console.WriteLine(qtd + " Unidade(s) retiradas do estoque.");

            }
            else
            {
                Console.WriteLine("Estoque atual contém " + Quantidade + " unidade(s). Retire um valor inferior ao escolhido.");
            }


        }

        public override string ToString()
        {
            return "\nProduto: " + Nome
                + "\nPreço: R$" + Preco.ToString("F2")
                + "\nQuantidade em estoque: " + Quantidade
                + "\nValor em estoque " + ValEstoque().ToString("F2");
        }


    }
}
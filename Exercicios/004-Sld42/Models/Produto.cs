using System;

namespace _004_Sld42
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValEstoque()
        {
            return quantidade * preco;
        }

        public void AddEstoque(int qtd)
        {
            quantidade += qtd;
            Console.WriteLine(qtd + " Unidade(s) adicionadas ao estoque.");
        }

        public void SubEstoque(int qtd)
        {
            if (quantidade >= qtd)
            {
                quantidade -= qtd;
                Console.WriteLine(qtd + " Unidade(s) retiradas do estoque.");

            }
            else
            {
                Console.WriteLine("Estoque atual contém " + quantidade + " unidade(s). Retire um valor inferior ao escolhido.");
            }


        }

        public override string ToString()
        {
            return "\nProduto: " + nome 
                + "\nPreço: R$" + preco.ToString("F2") 
                + "\nQuantidade em estoque: " + quantidade
                + "\nValor em estoque " + ValEstoque().ToString("F2");
        }

        
    }
}
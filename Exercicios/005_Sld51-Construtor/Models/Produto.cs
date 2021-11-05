using System;

namespace _005_Sld51_Construtor
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; } // Auto properties

        public Produto(string nome, double preco)//Construtores
        { //Construtor 
            _nome = nome.Substring(0, 1).ToUpper() + nome.Substring(1, nome.Length - 1);
            _preco = preco;
            Quantidade = 0;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome.Substring(0, 1).ToUpper() + nome.Substring(1, nome.Length - 1);
            _preco = preco;
            Quantidade = quantidade;
        }

        public Produto()
        { //Construtor padrão
        }

        //Properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    _nome = value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
                }
                else
                {
                    Console.WriteLine("O deve ter mais de um caracter");
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
                else
                {
                    Console.WriteLine("Valor não alterado. O produto não pode ser grátis");
                }
            }
        }

        //Métodos
        public double ValEstoque()
        {
            return Quantidade * _preco;
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
            return "\nProduto: " + _nome
                + "\nPreço: R$" + _preco.ToString("F2")
                + "\nQuantidade em estoque: " + Quantidade
                + "\nValor em estoque " + ValEstoque().ToString("F2");
        }


    }
}
using System;

namespace _006_Sld60_Ex
{
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular.Substring(0, 1).ToUpper() + titular.Substring(1, titular.Length - 1);
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double depInicial) : this(numero,titular)
        {
        
            if (depInicial > 0)
            {
                Deposito(depInicial);
            }
            else
            {
                Saldo = 0;
            }
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine("R$" + valor.ToString("F2") + " depositado com sucesso!");
            } else
            {
                System.Console.WriteLine("Nenhuma operação foi realizada.");
            }
            
        }

        public void Saque(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor + 5.00;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Nenhuma operação foi realizada.");
            }
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                    ";\nTitular: " + Titular +
                    ";\nSaldo: R$" + Saldo.ToString("F2") + ".";
        }

    }
}
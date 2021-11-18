using System;
using Sld146.Entities.Exceptions;

namespace Sld146.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0 || WithdrawLimit < 0)
            {
                throw new DomainException("Balance and withdraw limit must be greater or equal to zero.");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {   
            if (amount <= 0)
            {
                throw new DomainException("Amount deposited must be greater than zero.");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0) 
            {
                throw new DomainException("Amount withdrawn must be greater than zero.");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }

            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }

            Balance -= amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
namespace Entities{
    class Account
    {
        public int Number { get; protected set; } //protected não posso alterar no programa principal
        public string Holder { get; protected set; } //titular
        public double Balance { get; protected set; } //Saldo da conta
        public Account(){
            
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void Withdraw(double amount)//O método de saque pode ser sobreescrito ou sobreposto na subclasse
        {
            Balance -= amount + 5.0;
        } 
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
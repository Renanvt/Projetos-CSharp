using System;
using System.Collections.Generic;
using System.Text;
namespace Entities{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; } //titular
        public double Balance { get; set; } //Saldo da conta
        public Account(){
            
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(double amount)//saque recebe quantia como parâmetro de entrada
        {
            Balanca -= amount;
        } 
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
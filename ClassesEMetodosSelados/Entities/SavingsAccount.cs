using System;
using System.Collections.Generic;
using System.Text;
namespace Entities{
class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //Taxa de juros
        public SavingsAccount(){

        }
        public SavingsAccount(int number, string holder, double balance,double interestrate)
        :base(number,holder,balance)
        {
            InterestRate = interestrate;
        }
        public void UpdateBalance(){//Atualizar o dado da conta baseada na taxa de juros
        Balance += Balance * InterestRate;
        }
      public sealed override void Withdraw(double amount){//Essa operacao não pode ser Sobrescrita novamente em outra subclasse
          base.Withdraw(amount);
          Balance -= 2.0;
      }
    }
}
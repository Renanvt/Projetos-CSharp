using System;

namespace Entities{
    class BusinessAccount : Account //Conta de empresa vai ter tudo que uma conta tem
    {
      public double LoanLimit { get; set; }  //Limite para empréstimos
      public BusinessAccount(){

      }
      //CONSTRUTOR DA SUBCLASSE
      public BusinessAccount(int number, string holder, double balance, double loanlimit)
      : base(number,holder,balance){ 
          //Parâmetros de entrada do construtor de Account
          //Base(<Contrutor_da_superclasse>) //Chama o construtor da superclasse e depois acresçenta a quarta atribuição (loanlimit)
          LoanLimit = loanlimit;
      }

      public void Loan(double amount)
      {
          //A conta para empresas tem um limite para empréstismo
          if(amount <= LoanLimit)//Se dinheiro for menor que o limite
          {
            Balance += amount; //Saldo recebe dinheiro
          }
      }
    }
}
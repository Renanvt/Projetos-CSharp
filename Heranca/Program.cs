using System;
using Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
         /* //  BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
           // System.Console.WriteLine(account.Balance);
            Account acc = new Account(1001, "Alex",0.0);
            BusinessAccount bacc = new BusinessAccount(1002,"Maria",0.0,500.0);
            //UPCASTING
            Account acc1 =  bacc; //CORRETO a variável do tipo account recebe naturalmente um objeto de qualquer tipo de subclasse dela
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            //DOWNCASTING -> Operação insegura, usar somente quando necessário
            //BusinessAccount acc4 = acc2; // ERRO
            BusinessAccount acc4 =(BusinessAccount) acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0);//Loan não existe em acc2 porque é do tipo Account
            //BusinessAccount acc5 =(BusinessAccount) acc3; //ERRO -> SavingsAccount não é compatível com BusinessAccount
            if(acc3 is BusinessAccount){ //se a variável acc3 for uma instancia de BusinessAccount
                //acc3 não é uma instancia de BussinessAccount
                //BusinessAccount acc5 = (BusinessAccount) acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de fazer o CAST. Sintaxe alteranativa 
                acc5.Loan(200.0);
                System.Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount){//VERDADEIRO -> acc3 é uma instancia de SavingsAccount
                SavingsAccount acc5 =(SavingsAccount) acc3; //DOWNCAST
                acc5.UpdateBalance();
                System.Console.WriteLine("Update!");
            }
        */
        Account acc1 = new Account(1001, "Alex", 500.0);
        Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        acc1.Withdraw(10.0);
        acc2.Withdraw(10.0);
        Console.WriteLine(acc1.Balance);
        Console.WriteLine(acc2.Balance);


        }
    }
}

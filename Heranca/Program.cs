using System;
using Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            System.Console.WriteLine(account.Balance);
        }
    }
}

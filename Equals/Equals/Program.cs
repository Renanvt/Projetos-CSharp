using Equals.Entities;
using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };
            Console.WriteLine(a.Equals(b));

        }
    }
}

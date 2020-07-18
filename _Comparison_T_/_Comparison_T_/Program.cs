using _Comparison_T_.Entities;
using System;
using System.Collections.Generic;

namespace _Comparison_T_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 120.00));
            list.Add(new Product("Tablet", 450.00));

            /*Comparison<Product> comp = CompareProducts; Variável que guarda uma referencia para uma função
            list.Sort(comp);*/

            /*Expressão lambida, função anônima
             * Comp = (<argumentos da função>) <OperadorDeFuncao> <ExpressaoResultanteDosArgumentos>
             */
           // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
           // list.Sort(comp);

            /*Expressão lambida dentro da função Sort*/
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            //list.Sort(CompareProducts); //Só funciona se o tipo da lista implementa a interface IComparable
            //CompareProducts é uma referência para a função Sort - Delegate

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            
        }
       /* static int CompareProducts(Product p1, Product p2)
        {
            //Vai fazer o mesmo papel do IComparable
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
       */
    }
}

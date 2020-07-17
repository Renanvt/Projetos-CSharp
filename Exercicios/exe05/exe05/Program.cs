using System;
using System.Collections.Generic;

namespace exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> set = new HashSet<Students>();
            char[] course = new char[3];
            course[0] = 'A';
            course[1] = 'B';
            course[2] = 'C';
            int i=0, j;
            do
            {
                Console.Write($"Informe a quantidade de estudantes do curso {course[i]}: ");
                int n = int.Parse(Console.ReadLine());
                for (j = 0; j < n; j++)
                {
                    set.Add(new Students { Id = int.Parse(Console.ReadLine()) });
                }
                i++;
            } while (i < 3);
            Console.Write("Total de estudantes: ");
            Console.WriteLine(set.Count);
        }
    }
}

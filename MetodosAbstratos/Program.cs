using System;
using System.Globalization;
using System.Collections.Generic;
using Entities;
using Enums;
namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Entre com o número de figuras: ");
            int N = int.Parse(Console.ReadLine());
            for(int i=0; i<N; i++){
                System.Console.WriteLine("Dados da figura #"+ (i+1));
                System.Console.Write("Retângulo ou Circulo (r/c)? ");
                char op = char.Parse(Console.ReadLine());
                System.Console.Write("Cor (Black/Blue/Red): ");
                Color c = Enum.Parse<Color>(Console.ReadLine());
                if(op== 'r' || op == 'R'){
                    System.Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    System.Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width,height,c));
                }else{
                    System.Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius,c));
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Area das figuras: ");
            foreach (Shape obj in list)
            {
                System.Console.WriteLine(obj.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}

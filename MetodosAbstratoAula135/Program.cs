using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratoAula135.Entities;
using MetodosAbstratoAula135.Entities.Enums;


namespace MetodosAbstratoAula135
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Entre com a Qtde de figuras:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da figura Nº: {i}");
                Console.Write("É retângulo ou circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Digite a cor: (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Digite a largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite a altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Digite o raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }              
            }
            Console.WriteLine();

            Console.WriteLine("Área das figuras:");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}

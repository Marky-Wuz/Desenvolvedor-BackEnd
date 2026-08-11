using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_Com_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis - Instanciação de objetos
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            // Entrada de dados
            Console.WriteLine("Dados do triângulo X:");
            Console.Write("Lado A = ");
            x.a = double.Parse(Console.ReadLine());
            Console.Write("Lado B = ");
            x.b = double.Parse(Console.ReadLine());
            Console.Write("Lado C = ");
            x.c = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do triângulo Y:");
            Console.Write("Lado A = ");
            y.a = double.Parse(Console.ReadLine());
            Console.Write("Lado B = ");
            y.b = double.Parse(Console.ReadLine());
            Console.Write("Lado C = ");
            y.c = double.Parse(Console.ReadLine());

            // Processamento de dados - Saida de dados
            Console.WriteLine($"Área do triângulo X: {x.Area():F2}");
            Console.WriteLine($"Área do triângulo Y: {y.Area():F2}");
            Console.WriteLine($"Triangulo Maior: {(x.Area() > y.Area() ? "Area X" : "Area Y")}");
        }
    }
}

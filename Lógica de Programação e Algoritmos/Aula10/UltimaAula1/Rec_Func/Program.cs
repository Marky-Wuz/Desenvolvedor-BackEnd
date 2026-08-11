using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.WriteLine("Base do retângulo:");
            double baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura do retângulo:");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            // processamento
            double area = Area(baseRetangulo, alturaRetangulo);
            double perimetro = Perimetro(baseRetangulo, alturaRetangulo);
            double diagonal = Diagonal(baseRetangulo, alturaRetangulo);

            // Saída de dados
            Console.WriteLine($"Área: {area:f1}");
            Console.WriteLine($"Perímetro: {perimetro:f1}");
            Console.WriteLine($"Diagonal: {diagonal:f1}");


            // Funções
            double Area(double b, double a)
            {
                return b * a;
            }

            double Perimetro(double b, double a)
            {
                return 2 * (b + a);
            }

            double Diagonal(double b, double a)
            {
                return Math.Sqrt((b * b) + (a * a));
            }
        }
    }
}

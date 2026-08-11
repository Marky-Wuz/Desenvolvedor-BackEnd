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
            Func<double, double, double> cal_area = (b, a) => b * a;
            Func<double, double, double> cal_perimetro = (b, a) => 2 * (b + a);
            Func<double, double, double> cal_diagonal = (b, a) => Math.Sqrt((b * b) + (a * a));


            double area = cal_area(baseRetangulo, alturaRetangulo);
            double perimetro = cal_perimetro(baseRetangulo, alturaRetangulo);
            double diagonal = cal_diagonal(baseRetangulo, alturaRetangulo);


            // Saída de dados
            Console.WriteLine($"Área: {area.ToString()}");
            Console.WriteLine($"Perímetro: {perimetro.ToString()}");
            Console.WriteLine($"Diagonal: {diagonal.ToString()}");

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_Sem_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis
            double ladoA_x, LadoB_x, ladoC_x;
            double ladoA_y, LadoB_y, ladoC_y;
            double perimetro_X, perimetro_Y;
            double area_X, area_Y;

            // Entrada de dados
            Console.WriteLine("Entre com as medidas do triângulo X");
            Console.Write("Lado A = ");
            ladoA_x = double.Parse(Console.ReadLine());
            Console.Write("Lado B = ");
            LadoB_x = double.Parse(Console.ReadLine());
            Console.Write("Lado C = ");
            ladoC_x = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y");
            Console.Write("Lado A = ");
            ladoA_y = double.Parse(Console.ReadLine());
            Console.Write("Lado B = ");
            LadoB_y = double.Parse(Console.ReadLine());
            Console.Write("Lado C = ");
            ladoC_y = double.Parse(Console.ReadLine());

            // Processamento de dados

            // Cálculo do perímetro
            perimetro_X = (ladoA_x + LadoB_x + ladoC_x) / 2;
            perimetro_Y = (ladoA_y + LadoB_y + ladoC_y) / 2;

            // Areas dos triângulos
            area_X = Math.Sqrt(perimetro_X * (perimetro_X - ladoA_x) * (perimetro_X - LadoB_x) * (perimetro_X - ladoC_x));
            area_Y = Math.Sqrt(perimetro_Y * (perimetro_Y - ladoA_y) * (perimetro_Y - LadoB_y) * (perimetro_Y - ladoC_y));

            // Saída de dados
            Console.WriteLine("Área do triângulo X: " + area_X);
            Console.WriteLine("Área do triângulo Y: " + area_Y);
            Console.WriteLine("Triângulo de maior área: " + (area_X > area_Y ? "Area X" : "Area Y"));
            Console.ReadKey();
        }
    }
}

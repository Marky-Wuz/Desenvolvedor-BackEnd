using System;
using System.Linq;
using System.Threading.Tasks;

namespace Triangulo_Com_POO
{
    internal class Triangulo
    {
        // Membros
        // 1 Membros -> Campos
        public double a, b, c;

        // 2 Membros -> Métodos
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

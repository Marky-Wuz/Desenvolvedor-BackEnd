using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app1
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return largura + altura + largura + altura;
        }

        public double Diagonal()
        {
          return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2)); 
        }

        public void ExibirDados()
        {
            Console.WriteLine($"A Tua largura foi: {largura}\n" +
                $"A tua Altura foi: {altura}");

            Console.WriteLine($"A area do rêtangulo é de {Area()}\n" +
                $"O Perimetro foi de {Perimetro()}\n" +
                $"E a Diagonal de {Diagonal():f2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App3
{
    public class Aluno
    {
        private string nomealuno;
        private double nota1;
        private double nota2;
        private double nota3;

        public Aluno(string nomealuno, double nota1, double nota2, double nota3)
        {
            this.nomealuno = nomealuno;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3; 
        }

        public bool AprovadoouReprovado()
        {
            if (NotaFinal() > 60)
            {
                
                Console.WriteLine("Você passou!");
                return true;
            }
            else
            {
                Console.WriteLine("Você reprovou.");
                return false;
            }
        }

        public void Ponto()
        {
            if (NotaFinal() < 60)
            {
            double pontosfaltantes = 60 - NotaFinal();
            Console.WriteLine($"Pontos faltantes: {pontosfaltantes}");
            }
            else
            {
                
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nota final do {nomealuno} = {NotaFinal()}");
            AprovadoouReprovado();
        }
    }
}
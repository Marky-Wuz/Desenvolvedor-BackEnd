using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App2
{
    public class Funcionario
    {
        private string nome;
        private double salariobruto;
        private double imposto;
        private double porcentagem;

        public Funcionario(string nome, double salariobruto, double imposto)
        {
            this.nome = nome;
            this.salariobruto = salariobruto;
            this.imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return salariobruto - imposto; 
        }

        public void ExibirDados1()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                $"Salario Liquido: {SalarioLiquido():c}");
        }
        public double AumentarSalario(double porcentagem)
        {
            return salariobruto + (salariobruto * (porcentagem / 100));
        }

        public void ExibirDados2(double porcentagem)
        {
            Console.WriteLine($"Salario do {nome} aumentado em {porcentagem:f2}%");
            Console.WriteLine($"Dados do funcionario {nome} atualizados\n" +
                $"Funcionario: {nome}\n" +
                $"Salario Liquido: {AumentarSalario(porcentagem):c}");
        }
    }
}
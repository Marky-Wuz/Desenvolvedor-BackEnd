using System;
using System.Linq.Expressions;

try
{
// declaração de variaveis
int domingo = 1;
int segunda = 2;
int terça = 3;
int quarta = 4;
int quinta = 5;
int sexta = 6;
int sabado = 7;
int dia;

//entrada de dados
Console.Write("Digite o numero correspondente do dia da semana: ");
dia = int.Parse(Console.ReadLine());

//processamento de dados
if (dia == domingo)
{
    Console.WriteLine("O dia nesta semana é; Domingo.");
}
else if (dia == segunda)
{
    Console.WriteLine("O dia nesta semana é; Segunda.");
}
else if (dia == terça)
{
    Console.WriteLine("O dia nesta semana é; Terça.");
}
else if (dia == quarta)
{
    Console.WriteLine("O dia nesta semana é; Quarta.");
}
else if (dia == quinta)
{
    Console.WriteLine("O dia nesta semana é; Quinta.");
}
else if (dia == sexta)
{
    Console.WriteLine("O dia nesta semana é; Sexta.");
}
else if (dia == sabado)
{
    Console.WriteLine("O dia nesta semana é; Sabado.");
}
else
{
    Console.WriteLine("Insira um valor valido.");
}




}
catch
{
    Console.WriteLine("Digite um valor valido");
}


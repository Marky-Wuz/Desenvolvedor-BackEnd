//Declaração de variaveis
using Moeda;

double compra, cotação;

// entrada de dados
Console.Write("Digite a cotação do Dólar: ");
cotação = double.Parse(Console.ReadLine());
Console.Write("Quantos dólares você irá comprar? ");
compra = double.Parse(Console.ReadLine());

Console.WriteLine($"Valor á ser pago em reais = {ConversorDeMoeda.Comprar(cotação, compra):f2}");
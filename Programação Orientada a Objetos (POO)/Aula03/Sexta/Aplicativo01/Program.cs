//Declaração de variaveis
using Aplicativo01;
double raio;
Calculadora calculadora;

//Entrada de dados
Console.Write("Entre com o valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine()!);

//instantiação do objeto
calculadora = new Calculadora(raio);

//Saída de dados
Console.WriteLine($"Circunferencia: {calculadora.Circunferencia:f2}" +
    $"Volume: {calculadora.Volume:f2}");
calculadora.PI();
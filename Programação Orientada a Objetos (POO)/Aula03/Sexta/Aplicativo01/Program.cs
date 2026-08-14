//Declaração de variaveis
using Aplicativo01;
double raio;

//Entrada de dados
Console.Write("Entre com o valor do raio da circunferencia: ");
raio = double.Parse(Console.ReadLine()!);

//instantiação do objeto

//Saída de dados
Console.WriteLine($"Circunferencia: {Calculadora.Circunferencia(raio):f2}" +
    $"Volume: {Calculadora.Volume(raio)}");
Calculadora.PI();
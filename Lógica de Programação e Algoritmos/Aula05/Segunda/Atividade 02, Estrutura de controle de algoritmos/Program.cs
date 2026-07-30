// Declarações de variaveis
double a, b, c, Perimetro, Area, Resultadofinal;

Console.Title = "Atividade 02, Estrutura de controle de algoritmos.";
try
{
    // Entrada de dados
    Console.Write("Escreva o valor da base A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor da base B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Escreva o valor da altura C: ");
    c = double.Parse(Console.ReadLine());

    // Processamento de dados
    FinalABC();
    if ((a + b) > c & (a + c) > b & (b + c) > a)
    {
        Perimetrofinal();
        Console.WriteLine($"Perimetro; {Resultadofinal:f1}");
    }
    else
    {
        Areafinal();
        Console.WriteLine($"Area; {Resultadofinal:f1}");

    }
}
catch
{
    Console.WriteLine("Digite valores válidos");
}
double Perimetrofinal()
{
    Perimetro = a + b + c;
    return Perimetro;
}

double Areafinal()
{
    Area = a + b - c;
    return Area;
}
double FinalABC()
{
    Resultadofinal = a + b + c;
    return Resultadofinal;
}

Console.ReadKey();
// declaração de variaveis
double nota1, nota2, notafinal;

Console.Title = "Boletim";

try
{
    //entrad de dados
    Console.Write("Digite a 1 nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a 2 nota: ");
    nota2 = double.Parse(Console.ReadLine());
    //Processamento de dados
    Nota();
    //Saída de dados
    Console.WriteLine($"Nota final = {notafinal:f1}");
    if (notafinal < 60)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reprovado");
    }
    if (notafinal > 60) 
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Aprovado");

    }
}

catch
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}

Console.ReadKey();
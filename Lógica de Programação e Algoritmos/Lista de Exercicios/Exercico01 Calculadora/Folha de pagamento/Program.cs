// Declaração de variavel
double salario, aumento, percentual;

try
{
    //Entrada de dados
    Console.Write("Qual seu salário: ");
    salario = double.Parse(Console.ReadLine());
    if (salario < 280)
    {
        percentual = 20;
    }
    else if (salario >= 280 & salario < 700)
    {
        percentual = 15;
    }
    else if (salario > +700 & salario < 1500)
    {
        percentual = 10;
    }
    else
    {
        percentual = 5;
    }

    Valorfinal();
    // Saída de dados
    Console.WriteLine($"Salário antes do reajuste; {salario:c}");
    Console.WriteLine($"Percentual de aumento aplicado; {percentual:c}");
    Console.WriteLine($"Valor do aumento; {aumento:c}");
    Console.WriteLine($"Valor final do salario; {salario + aumento:c}");
}
catch
{
    Console.WriteLine("Valor invalidado");
}
double Valorfinal()
{
    aumento = salario * percentual / 100;
        return aumento;
}
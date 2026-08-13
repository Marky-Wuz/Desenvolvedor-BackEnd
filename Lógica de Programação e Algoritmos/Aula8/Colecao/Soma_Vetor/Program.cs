//Declaração de variaveis
double[] numeros;
double valores, soma, media;
int n;

try
{
    // Entrada de dados
    Console.Write("Quantos numeros voce vai digitar? ");
    n = int.Parse(Console.ReadLine());
    numeros = new double[n];

    //Loop 
    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um numero: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("Valores =");
    foreach (var item in numeros)
    {
        Console.WriteLine($" {item} ");
    }
    media = numeros.Average();
    soma = numeros.Sum();
    Console.WriteLine($"A soma dos valores digitados é: {soma}");
    Console.WriteLine($"A media dos valores digitados é: {media:f2}");
}
catch (Exception e)
{

    Console.WriteLine($"Valor invalido, Erro: {e}. Tente novamente!");
}

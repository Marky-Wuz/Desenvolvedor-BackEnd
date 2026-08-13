// Declaração de variaveis
List<int> numeros = new List<int>();
int n, valor;

try
{
    // entrada de dados
    Console.Write("Quantos numeros voce vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //loop determinado
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite um número; ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }

    Console.WriteLine("NUMEROS NEGATIVOS: ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }
    }
}
catch (Exception e)
{

    Console.WriteLine($"Valor invalidado, Erro: {e}. Tente novamente!");
}
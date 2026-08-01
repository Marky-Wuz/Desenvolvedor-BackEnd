//Declaração de variaveis
int x, y;

do
{
    Console.Write("Digite dois números: ");
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    if (x < y)
    {
        Console.WriteLine("Crescente");
    }
    else if (x > y)
    {
        Console.WriteLine("Decrescente");
    }
} while (x != y);

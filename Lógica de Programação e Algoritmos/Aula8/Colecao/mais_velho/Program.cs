// declaração de variaveis
Dictionary<string, int> pessoas = new Dictionary<string, int>();
string nome;
int idade, n;

try
{
    // Entrada de dados
    Console.Write("Quantas pessoas voce vai digitar: ");
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Dados da {i + 1}ª pessoa: ");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("idade: ");
        idade = int.Parse(Console.ReadLine());
        pessoas.Add(nome, idade);
    }
    foreach (var item in pessoas)
    {
        if (item.Value == pessoas.Values.Max())
        {
            Console.WriteLine($"Pessoa mais velha: {item.Key}");
        }
    }
}
catch (Exception e)
{

    Console.WriteLine($"Valor invalido, Erro: {e}. Tente novamente!");
}

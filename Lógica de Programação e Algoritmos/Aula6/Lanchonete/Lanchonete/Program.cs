// declaração de variaveis
int codigo, quantidade;
double preço;

// entrada de dados
Console.Write("Digite o codigo do produto: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de produto: ");
quantidade = int.Parse(Console.ReadLine());


// estrutura de controle de seleção - switch case
switch (codigo)
{
    case 1:
        // Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar? R$ {quantidade * 5.00}");
        break;
    case 2:
        // Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar? R$ {quantidade * 3.50}");
        break;
    case 3:
        // Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar? R$ {quantidade * 4.80}");
        break;
    case 4:
        // Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar? R$ {quantidade * 8.90}");
        break;
    case 5:
        // Produto 1 - R$ 5.00
        Console.WriteLine($"Valor a pagar? R$ {quantidade * 7.32}");
        break;
    default:
        Console.WriteLine("Código invalido, tente novamente!");
        break;
    }
using static System.Linq.Enumerable;
using static System.Console;

// Declaração de variaveis
int x, y, controle, control;
int impar = 0;

try
{
	//Entrada de dados
	WriteLine("Digite dois numero: ");
	x = int.Parse(ReadLine()!);
	y = int.Parse(ReadLine()!);

	//Processamento de dados
	if (x < y)
	{
		controle = x;
		control = y;
	}
	else
	{
		controle = y; 
		control = x;
	}

    foreach (int a in Range(controle, control))
    {
        if (a%2 != 0 & a != x & a!= y)
        {
			impar += a;
        }
		if (a == control)
		{
			break;
		}
    }
	WriteLine($"A soma dos numeros impares é: {impar}");
}
catch (Exception erro)
{

	WriteLine($"Ocorreu um erro: {erro.Message}");
}

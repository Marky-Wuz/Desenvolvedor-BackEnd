//Problema "Idades"

//Declaração de variaveis
var nome1 = "SENAI";
var nome2 = "SENAI";
var idade1 = 1;
var idade2 = 2;
var media = 1.73f;

//Entrada de dados
Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
nome1 = Console.ReadLine();
Console.Write("Idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da Segunda pessoa: ");
Console.Write("Nome: ");
nome2 = Console.ReadLine();
Console.Write("idade: ");
idade2 = int.Parse(Console.ReadLine());

//Processamento de dados
media = (idade1 + idade2) / 2;

//Saída de dados
Console.WriteLine($"A média de {nome1} e {nome2} é de {media:f1}");

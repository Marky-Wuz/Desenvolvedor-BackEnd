//Declaração de variaveis
using App3;

string nome;
double nota1, nota2, nota3;

// Entrada de dados
Console.Write("Qual é o Nome do Aluno: ");
nome = Console.ReadLine();
Console.WriteLine($"Digite as tres notas do {nome}");
nota1 = double.Parse(Console.ReadLine());
nota2 = double.Parse(Console.ReadLine());
nota3 = double.Parse(Console.ReadLine());

Aluno escola = new Aluno(nome, nota1, nota2, nota3);

escola.NotaFinal();
escola.Ponto();
escola.ExibirDados();
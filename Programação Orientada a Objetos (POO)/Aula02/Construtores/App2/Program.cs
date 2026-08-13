//declaração de variaveis
using App2;

string nome;
int salarioB;
int imposto;
double porcentagem;

// Entrada de dados
Console.Write("Digite o Nome do funcionario: ");
nome = Console.ReadLine();
Console.Write($"Digite o salario bruto de {nome}: ");
salarioB = int.Parse(Console.ReadLine());
Console.Write($"Digite o valor total de impostos á pagar do {nome}: ");
imposto = int.Parse(Console.ReadLine());

Funcionario abacaxi = new Funcionario(nome, salarioB, imposto);

abacaxi.ExibirDados1();

Console.Write($"Digite a porcentagem que quer adicionar ao salario de {nome}: ");
porcentagem = double.Parse(Console.ReadLine());
abacaxi.AumentarSalario(porcentagem);
abacaxi.ExibirDados2(porcentagem);
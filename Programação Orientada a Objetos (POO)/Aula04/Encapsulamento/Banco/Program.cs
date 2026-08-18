
using Banco;
// declaração de variaveis
string nome;
int numero;
double saldo, quantia;
char escolha;
ContaBancaria conta1;

// entrada de dados
Console.Write("Digite o ID(numero) da conta: ");
numero = int.Parse(Console.ReadLine());
Console.Write("Escreva o nome do colaborador: ");
nome = Console.ReadLine();
Console.Write("Deseja depositar inicial? (S/N): ");
escolha = char.Parse(Console.ReadLine().ToLower());

if (escolha == 's')
{
    Console.Write("Digite o quanto quer depositar: ");
    saldo = double.Parse(Console.ReadLine());
    conta1 = new ContaBancaria(nome, numero, saldo);
}
else
{
    conta1 = new ContaBancaria(nome, numero);
}
Console.WriteLine(conta1.ExibirDados());

Console.Write("Entre com um valor para deposito: ");
quantia = double.Parse(Console.ReadLine());
conta1.Deposito(quantia);
Console.WriteLine("\t--- Dados Atualizados! ---");
Console.WriteLine(conta1.ExibirDados());
Console.Write("Entre com um valor para saque: ");
quantia = double.Parse(Console.ReadLine());
conta1.Saque(quantia);
Console.WriteLine("\t-- Dados Atualizados --");
Console.WriteLine(conta1.ExibirDados());


Console.ReadKey();
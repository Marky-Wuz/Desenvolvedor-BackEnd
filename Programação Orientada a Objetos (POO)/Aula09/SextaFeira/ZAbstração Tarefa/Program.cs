using ZAbstração_Tarefa.Classes.Entidades;
using ZAbstração_Tarefa.Enumeracoes;

List<Impostos> ListaFuncionarios = new();

Console.WriteLine("Escolha o Contribuinte" +
    "\t1 - Juridica" +
    "\t2- Fisica\n");
int escolha = int.Parse(Console.ReadLine());
Console.Write("Digite o Nome do Contribuinte: ");
string nome = Console.ReadLine();
Console.Write("Digite a Renda Anual do Contribuinte: ");
double renda = double.Parse(Console.ReadLine());

if (Pessoa.Fisica.Equals((Pessoa)escolha))
{
    Console.Write("Digite o seu Gasto com Saúde: ");
    double gasto = double.Parse(Console.ReadLine());
    ListaFuncionarios.Add(new Fisica(renda, nome, gasto));

}
else if (Pessoa.Juridica.Equals((Pessoa)escolha))
{
    Console.Write("Digite quantos Funcionarios voce tem: ");
    int funcionarios = int.Parse(Console.ReadLine());
    ListaFuncionarios.Add(new Juridica(renda, nome, funcionarios));

}

foreach (var abacaxi in ListaFuncionarios)
{
    abacaxi.ExibirDados();
}

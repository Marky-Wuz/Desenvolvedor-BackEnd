//Declaração de variaveis
using Pessoas.Classes.Entidades;

int n;

List<Funcionario> listaFuncionario = new();

// Entrada de dados
Console.Write("Deseja registrar quantos funcionarios? ");
n = int.Parse(Console.ReadLine());

//Processamento de dados
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Colaborador n° {i + 1}");
    Console.Write("O Funcionario é terceriza? (s/n) ");
    char escolha = char.Parse(Console.ReadLine().ToLower());
    Console.Write("Nome do funcionario: ");
    string nome = Console.ReadLine();
    Console.Write("Quantidade de Horas trabalhadas: ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write($"Valor da hora do {nome}: ");
    double valor = double.Parse(Console.ReadLine());

    if (escolha == 's')
    {
        //Criar um funcionario tercerizado
        listaFuncionario.Add(new Terceiro(valor, horas, nome));
    }
    else
    {
        //Criar um funcionario normal
        listaFuncionario.Add(new Funcionario(valor, horas, nome));
    }
}

    Console.WriteLine("Pagamentos: ");

foreach (var pessoa in listaFuncionario)
{
    Console.WriteLine($"Nome: {pessoa.NomeDoFuncionario} - Pagamento: {pessoa.Pagamento()}");
}
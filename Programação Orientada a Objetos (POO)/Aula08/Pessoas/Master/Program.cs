using Master.Classes.Entidades;
using Master.Enumerações;

//Declaração de variaveis
string titulo;
int numero;
double saldo, taxa, emprestimo;
Conta conta;

// Entrada de dados
Console.WriteLine("Deseja abrir qua tipo de conta" +
    "\n1 - Conta PF(Pessoal Fisica)\t" +
    "\n2 - Conta Poupança\t" +
    "\n3 - Conta Empresa\t");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        conta.ExibirDados();
        Console.Write("Deseja iniciar Operações Bancarias? (s/n) ");
        char op = char.Parse(Console.ReadLine());
        if (op == 's')
        {
            operacoes();
        }
        else
        {
            break;
        }
        break;
    case 2:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Poupanca}");
        AbrirPoupanca();
        conta.ExibirDados();
        Console.Write("Deseja iniciar Operações Bancarias? (s/n) ");
        char op2 = char.Parse(Console.ReadLine());
        if (op2 == 's')
        {
            operacoes();
        }
        else
        {
            break;
        }
        break;
    case 3:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        conta.ExibirDados();
        Console.Write("Deseja iniciar Operações Bancarias? (s/n) ");
        char op3 = char.Parse(Console.ReadLine());
        if (op3 == 's')
        {
            operacoes();
        }
        else
        {
            break;
        }
        break;
    default:
        Console.WriteLine("Nenhuma opção selecionada.");
        conta = null;
        break;
}

void AbrirConta()
{
    Console.Write("Fale o Titular da Conta: ");
    titulo = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write("Deseja iniciar com Saldo Ativo? (s/n)");
    char opcao = char.Parse(Console.ReadLine());
    if (opcao == 's')
    {
        Console.Write("Qual é o valor do Deposito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta = new Conta(numero, titulo, saldo);
    }
    else
    {
        conta = new Conta(numero, titulo);
    }
}

void AbrirPoupanca()
{
    Console.Write("Fale o Titular da Conta: ");
    titulo = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write("Taxa da Conta: ");
    taxa = double.Parse(Console.ReadLine());
    Console.Write("Deseja iniciar com Saldo Ativo? (s/n)");
    char opcao = char.Parse(Console.ReadLine());
    if (opcao == 's')
    {
        Console.Write("Qual é o valor do Deposito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaPoupanca(numero, titulo, saldo, taxa);
    }
    else
    {
        conta = new ContaPoupanca(numero, titulo, taxa);
    }
}

void AbrirEmpresa()
{
    Console.Write("Fale o Titular da Conta: ");
    titulo = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.WriteLine($"Numero da conta: {numero}");
    Console.Write($"Limite de Emprestimo: ");
    emprestimo = double.Parse(Console.ReadLine());
    Console.Write("Deseja iniciar com Saldo Ativo? (s/n)");
    char opcao = char.Parse(Console.ReadLine());
    if (opcao == 's')
    {
        Console.Write("Qual é o valor do Deposito inicial? ");
        saldo = double.Parse(Console.ReadLine());
        conta = new ContaEmpresa(numero, titulo, saldo, emprestimo);
    }
    else
    {
        conta = new ContaEmpresa(numero, titulo, emprestimo);
    }
}

void operacoes()
{
    Console.WriteLine("Selecione Atividade Bancaria: ");
    Console.Write("\t 1 - Sacar\n" +
        "\t 2 - Depositar\n");
    int escolha2 = int.Parse(Console.ReadLine());

    switch (escolha2)
    {
        case 1:
            Console.Write("Selecione o valor que gostaria de Sacar: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            conta.ExibirDados();
            break;
        case 2:
            Console.Write("Selecione o valor que gostaria de depositar");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            conta.ExibirDados();
            break;
        default:
            break;
    }
}
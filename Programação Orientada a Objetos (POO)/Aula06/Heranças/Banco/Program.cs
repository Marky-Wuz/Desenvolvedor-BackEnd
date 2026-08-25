using Banco.Classes.Entidade;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;

string titular;
int id;

bool sair = true;
Conta conta1;
ContaPoupança conta2;
ContaEmpresa conta3;
while (sair != false)
{
    Console.WriteLine("Selecione qual tipo de conta deseja abrir:\n" +
    "\t 1 - Conta Normal\n" +
    "\t 2 - Conta poupança\n" +
    "\t 3 - Conta Empresa\n" +
    "\t 4 - Sair\n");
    int selecao = int.Parse(Console.ReadLine());

    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionado Conta Normal");
            await Task.Delay(3000);
            Opcao1();
            Console.WriteLine(conta1.ToString());
            break;
        case 2:
            Console.WriteLine("Selecionado Conta Poupança");
            await Task.Delay(3000);
            Opcao2();
            Console.WriteLine(conta2.ToString()); 
            break;
        case 3:
            Console.WriteLine("Selecionado Conta Empresa");
            Opcao3();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            await Task.Delay(3000);
            sair = false;
            break;
        default:
            Console.WriteLine("Selecionado nenhuma das opções oferecidas. Tente novamente!");
            break;
    }

}
void Opcao1()
{
    Console.Write("Qual seria o titular da conta: ");
    titular = Console.ReadLine();
    Console.Write("Qual seria o ID da conta: ");
    id = int.Parse(Console.ReadLine());
    Console.WriteLine("Deseja fazer deposito inicial ? (s/n)");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        conta1 = new Conta(titular, id);
    }
    else
    {
        Console.Write("Qual valor do deposito inicial?");
        double saldo = double.Parse(Console.ReadLine());
        conta1 = new Conta(titular, id, saldo);

        Console.WriteLine(conta1.ToString());
    }


    Console.WriteLine("Selecione oque deseja:\n" +
        "\t 1 - Sacar\n" +
        "\t 2 - Depositar\n" +
        "\t 3 - Atualizar Saldo\n" +
        "\t 4 - Finalizar Sessão\n");
    int selecao2 = int.Parse(Console.ReadLine());

    switch (selecao2)
    {
        case 1:
            Console.Write("Vale o valor que gostaria de Sacar: ");
            double quantia = double.Parse(Console.ReadLine());
            int taxa = int.Parse(Console.ReadLine());
            conta1.Saque(quantia);
            break;
        case 2:
            Console.Write("Vale o valor que gostaria de Depositar: ");
            double quantia2 = double.Parse(Console.ReadLine());
            conta1.Deposito(quantia2);
            break;
        case 3:
            Console.Write("Entre com o novo Saldo: ");
            double quantia3 = double.Parse(Console.ReadLine());
            conta1.Deposito(quantia3);
            break;
        case 4:
            Console.WriteLine("Saindo...");
            sair = false;
            break;
    }
}

void Opcao2()
{
    Console.Write("Qual seria o titular da conta: ");
    titular = Console.ReadLine();
    Console.Write("Qual seria o ID da conta: ");
    id = int.Parse(Console.ReadLine());
    Console.WriteLine("Deseja fazer deposito inicial ? (s/n)");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        conta1 = new Conta(titular, id);
    }
    else
    {
        Console.Write("Qual valor do deposito inicial?");
        double saldo = double.Parse(Console.ReadLine());
        conta1 = new Conta(titular, id, saldo);

    }


    Console.WriteLine("Selecione oque deseja:\n" +
        "\t 1 - Sacar\n" +
        "\t 2 - Depositar\n" +
        "\t 3 - Atualizar Saldo\n" +
        "\t 4 - Finalizar Sessão\n");
    int selecao2 = int.Parse(Console.ReadLine());
    double taxa1;
    taxa1 = double.Parse(Console.ReadLine());
    conta2 = new ContaPoupança(titular, id, taxa1);

    switch (selecao2)
    {
        case 1:
            Console.Write("Vale o valor que gostaria de Sacar: ");
            double quantia = double.Parse(Console.ReadLine());
            double taxa = int.Parse(Console.ReadLine());
            conta2.Saque(quantia + taxa);
            break;
        case 2:
            Console.Write("Vale o valor que gostaria de Depositar: ");
            double quantia2 = double.Parse(Console.ReadLine());
            conta2.Deposito(quantia2);
            break;
        case 3:
            Console.Write("Entre com o novo Saldo: ");
            double quantia3 = double.Parse(Console.ReadLine());
            conta2.Deposito(quantia3);
            conta2.AtualizaçãoDeSaldo();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            sair = false;
            break;
    }
}

void Opcao3()
{
    Console.Write("Qual seria o titular da conta: ");
    titular = Console.ReadLine();
    Console.Write("Qual seria o ID da conta: ");
    id = int.Parse(Console.ReadLine());
    Console.WriteLine("Deseja fazer deposito inicial ? (s/n)");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        conta1 = new Conta(titular, id);
    }
    else
    {
        Console.Write("Qual valor do deposito inicial?");
        double saldo = double.Parse(Console.ReadLine());
        conta1 = new Conta(titular, id, saldo);

    }


    Console.WriteLine("Selecione oque deseja:\n" +
        "\t 1 - Sacar\n" +
        "\t 2 - Depositar\n" +
        "\t 3 - Atualizar Saldo\n" +
        "\t 4 - Finalizar Sessão\n");
    int selecao2 = int.Parse(Console.ReadLine());
    double taxa1;
    taxa1 = double.Parse(Console.ReadLine());
    conta2 = new ContaPoupança(titular, id, taxa1);

    switch (selecao2)
    {
        case 1:
            Console.Write("Vale o valor que gostaria de Sacar: ");
            double quantia = double.Parse(Console.ReadLine());
            double taxa = int.Parse(Console.ReadLine());
            conta2.Saque(quantia + taxa);
            break;
        case 2:
            Console.Write("Vale o valor que gostaria de Depositar: ");
            double quantia2 = double.Parse(Console.ReadLine());
            conta2.Deposito(quantia2);
            break;
        case 3:
            Console.Write("Entre com o novo Saldo: ");
            double quantia3 = double.Parse(Console.ReadLine());
            conta2.Deposito(quantia3);
            conta2.AtualizaçãoDeSaldo();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            sair = false;
            break;
    }
}
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using Banco.Classes.Contextos;
using Microsoft.Identity.Client.NativeInterop;
using Banco.Classes.Entidades;

ContaContext contexto = new ContaContext();
//contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu principal --" +
        "\n 1 - Cadastrar Conta" +
        "\n 2 - Consultar Conta Existente" +
        "\n 3 - Sair");
    Console.Write("\n Escolha uma das Opções Acima: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //Cadastrar Conta
            CadastrarConta(contexto);
            break;

        case "2":
            //Consultar uma Conta
            ConsultaConta(contexto);
            break;
        case "3":
            Console.WriteLine("Encerrando Sistema, aguarde...");
            continuar = false;

            break;
    }
}

void CadastrarConta(ContaContext conta)
{
    Console.WriteLine("=== Cadastro de Conta ===");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    Console.Write("Digite o Titular da conta: ");
    string titular = Console.ReadLine();
    Console.Write("Terá deposito inicial (s/n)? ");
    char escolha = char.Parse(Console.ReadLine().ToLower());

    var numeroContaExistente = conta.contas.FirstOrDefault(c => c.NumeroDaConta == numero);
    if (numeroContaExistente != null)
    {
        Console.WriteLine($"\n Erro: Já existe uma conta com o número {numero}");
        return;
    }
    Conta contaCriada;

    if (escolha == 's')
    {
        Console.Write("QUal valor do depósito inicial? ");
        decimal deposito = decimal.Parse(Console.ReadLine());
        contaCriada = new Conta(numero, titular, deposito);
    }
    else
    {
        contaCriada = new Conta(numero, titular, 0);

    }

    conta.contas.Add(contaCriada);
    conta.SaveChanges();
    Console.WriteLine("\nConta cadastrada com Sucesso!\n");
    contaCriada.ExibirDados();
}
void ConsultaConta(ContaContext conta)
{
    Console.WriteLine("=== Consulta de conta ===");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    var contaConsultada = conta.contas.FirstOrDefault(c => c.NumeroDaConta.Equals(numero));
    if (contaConsultada == null)
    {
        Console.WriteLine($"\nConta {numero} não encontrada");
        return;
    }

    contaConsultada.ExibirDados(); // Read

    continuar = true;

    while (continuar)
    {
        Console.WriteLine("-- Operações --");
        Console.WriteLine("\n 1 - Deposito" +
            "\n 2 - Sacar" +
            "\n 3 - Alterar Titular da conta" +
            "\n 4 - Voltar ao Menu principal");
        Console.WriteLine("--  Escolha --");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                //Operação Deposito
                Console.Write("Quanto gostaria de Depositar");
                decimal valor = decimal.Parse(Console.ReadLine());
                contaConsultada.Depositar(valor);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 2:
                //Operações de sacar
                Console.Write("Quanto gostaria de sacar?");
                decimal sacar = decimal.Parse(Console.ReadLine());
                contaConsultada.Sacar(sacar);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 3:
                //Operação de alteração de titular
                Console.Write("Qual será o novo nome do titular? ");
               contaConsultada.TitularDaConta = Console.ReadLine();
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 4:
                //sair
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }
}

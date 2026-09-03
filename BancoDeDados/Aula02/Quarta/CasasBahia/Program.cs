using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("1 - Consultar produtos no estoque");
    Console.WriteLine("2 - Cadastrar novo produto");
    Console.WriteLine("3 - Retirar algum Item");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("--------------------------------");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("--------------------------------");
            Console.Write($"Digite o codigo do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Produto não encontrado: {codigo}, Deseja voltar ao menu? (s/n)");
                string resposta1 = Console.ReadLine();
                if (resposta1.ToLower() == "s")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Desligando o Sistema, aguarde...");
                   await Task.Delay(1000);
                    break;
                }
            }
            Console.WriteLine("--------------------------------");
            break;
        case 2:
            CadastroDeItem(contexto);
            break;
        case 3:
            RetirarItem(contexto);
            break;
        case 4:
            Console.WriteLine("--------------------------------");
            continuar = false;
            Console.WriteLine("Gostaria de sair? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
            {
                Console.WriteLine("Desligando o Sistema, aguarde...");
                await Task.Delay(3500);
                Console.WriteLine("Bebendo água....");
                await Task.Delay(2500);
                Console.WriteLine("Cortando abacaxi...");
                await Task.Delay(1000);
                Console.WriteLine("Sistema Desligado");
                continuar = false;
            }
            return;
            Console.WriteLine("--------------------------------");
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    void CadastroDeItem(ProdutoContexto produto)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Cadastro de Item");
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome do produto não pode ser apenas espaços em branco. Cadastro cancelado.");
            return;
        }
        Console.Write("Digite o valor do produto: ");
        decimal valor = decimal.Parse(Console.ReadLine());
        if (valor <= 0)
        {
            Console.WriteLine("Valor do produto deve ser maior que zero. Cadastro cancelado.");
            return;
        }
        Console.Write("Digite a quantidade do produto: ");
        int quantidade = int.Parse(Console.ReadLine());
        var novoProduto = new Produto(nome, valor, quantidade);
        produto.Produtos.Add(novoProduto);
        produto.SaveChanges();
        Console.WriteLine("Produto cadastrado com sucesso!");
        novoProduto.ExibirDados();
        Console.WriteLine("--------------------------------");
    }

    void RetirarItem(ProdutoContexto produto)
    {
        Console.WriteLine("--------------------------------");
        Console.Write("Digite o código do produto a ser retirado: ");
        int codigo = int.Parse(Console.ReadLine());
        var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
        if (codigoProduto != null)
        {
            codigoProduto.ExibirDados();
        }
        else
        {
            Console.WriteLine($"Produto não encontrado: {codigo}, Voltando ao menu");
            string resposta1 = Console.ReadLine();
            return;
        }
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Gostaria de remover este produto? (s/n)");
        char opcao = char.Parse(Console.ReadLine().ToLower());
        if (opcao == 's')
        {
            var produtoARemover = produto.Produtos.FirstOrDefault(p => p.CodigoDoProduto == codigo);
            if (produtoARemover != null)
            {
                produto.Produtos.Remove(produtoARemover);
                produto.SaveChanges();
                Console.WriteLine("Produto removido com sucesso!");
                return;
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operação cancelada. Voltando ao menu.");
            return;
        }
        
    }

}


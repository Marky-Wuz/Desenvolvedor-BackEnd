
using Estoque;

// declaração de variaveis
string nome;
int qtd;
double preco;


// entrada de dados
Console.Write("Digite o nome do produto: ");
nome = Console.ReadLine();
Console.Write($"Qual será a quantidade de {nome} ao seu carrinho de compras? ");
qtd = int.Parse(Console.ReadLine());
Console.Write($"Digite o preço de {nome}: ");
preco = double.Parse(Console.ReadLine());


Produto objeto = new Produto(nome,qtd,preco);
Produto objeto2 = new Produto(nome, preco);


Console.WriteLine();
Console.ReadKey();

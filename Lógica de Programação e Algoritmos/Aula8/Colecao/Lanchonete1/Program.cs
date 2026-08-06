//Declaração de variaveis
Dictionary<int, double> produtos = new Dictionary<int, double>()
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}
};
int codigo, quantidade;
double preco;

try
{
    //entrada de dados
    Console.Write("Digite o codigo do produto: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade de produtos: ");
    quantidade = int.Parse(Console.ReadLine());

    //Processamento de dados
    preco = quantidade * produtos[codigo];

    //Saida de dados
    Console.WriteLine($"Valor á pagar: {preco:c}");
}
catch (Exception e)
{

    Console.WriteLine($"Valor invalido, Erro: {e}");
}
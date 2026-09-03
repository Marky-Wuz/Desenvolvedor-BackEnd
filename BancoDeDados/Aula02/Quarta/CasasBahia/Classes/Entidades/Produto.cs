namespace CasasBahia.Classes.Entidades
{
    internal class Produto
    {

        //Propriedades
        public int CodigoDoProduto { get; set; }
        public string NomeDoProduto { get; set; }
        public decimal ValorDoProduto { get; set; }
        public int QuantidadeDeProduto { get; set; }

        //Construtor
        public Produto(string nomeDoProduto, decimal valorDoProduto, int quantidadeDeProduto)
        {
            NomeDoProduto = nomeDoProduto;
            ValorDoProduto = valorDoProduto;
            QuantidadeDeProduto = quantidadeDeProduto;
        }

        //Métodos

        public void ExibirDados()
        {
            Console.WriteLine($"Código: {CodigoDoProduto}");
            Console.WriteLine($"Nome: {NomeDoProduto}");
            Console.WriteLine($"Valor: {ValorDoProduto:C}");
            Console.WriteLine($"Quantidade: {QuantidadeDeProduto}");
        }
    }

}
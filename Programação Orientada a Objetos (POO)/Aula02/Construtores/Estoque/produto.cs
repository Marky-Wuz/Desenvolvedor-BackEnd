namespace Estoque
{
    internal class Produto
    {
        //Campos
        string nome;
        int quantidades;
        double preco;

        //Construtores
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidades = quantidades;
            this.preco = preco;
        }

        //Métodos

        public void AdicionarP(int qtd)
        {
            quantidades += qtd;
        }
        public void RemoverP(int qtd)
        {
            quantidades -= qtd;
        }
        public double ValorTotal()
        {
            return quantidades * preco;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n " +
                $"Quantidade: {quantidades}\n" +
                $"Preço: {preco:c}\n" +
                $"Total á se pagar: {ValorTotal():c}");
        }
    }
}

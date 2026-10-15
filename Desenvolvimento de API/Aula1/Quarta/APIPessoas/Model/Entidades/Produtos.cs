namespace APIPessoas.Model.Entidades
{
    public class Produtos
    {

        public int Id { get; set; }
        public string NomeDoProduto { get; set; }
        public decimal PrecoDoProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }


        public Produtos(string nomeDoProduto, decimal precoDoProduto, string descricao, int quantidade)
        {
            NomeDoProduto = nomeDoProduto;
            PrecoDoProduto = precoDoProduto;
            Descricao = descricao;
            Quantidade = quantidade;
        }
    }
}

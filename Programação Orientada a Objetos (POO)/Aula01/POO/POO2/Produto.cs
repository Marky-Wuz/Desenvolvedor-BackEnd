

using System;

namespace POO2
{
    internal class Produto
    {
        //Campos
        public string nome;
        public double preco;
        public int quantidade;

        //Metodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                $" Preço: {preco:c}\n" +
                $" Quantidade: {quantidade}\n" +
                $"Valor total em estoque: {ValorEmEstoque():c}");
        }

        public void AdicionarProdutos(int q)
        {
            quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            quantidade -= q;
        }

        public double ValorEmEstoque()
        {
            return quantidade * preco;
        }
    }
}
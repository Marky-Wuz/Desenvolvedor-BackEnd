using Biblioteca.Interfaces;

namespace Biblioteca.Classes.Entidades
{
    internal class ItemBiblioteca : IMovimentacao, Iinformacoes
    {
        //Campos
        string titulo;
        DateTime ano;
        int quantidade;


        //Propriedades
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public DateTime AnoPublicacao
        {
            get { return ano; }
            set { ano = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        
        //Construtores
        public ItemBiblioteca(string titulo, DateTime anoPublicacao)
        {
            AnoPublicacao = anoPublicacao;
            Titulo = titulo;
            quantidade = 0;
        }
        public ItemBiblioteca(int quantidade, DateTime anoPublicacao, string titulo) : this(titulo, anoPublicacao)
        {
            Titulo = titulo;
        }

        //Métodos
        public void Devolver(int quantia)
        {
            Quantidade += quantia;
        }

        public void Emprestar(int quantia)
        {
            Quantidade -= quantia;
        }

        public virtual string Exibir() 
        {
            return ("Dados do item\n" +
                $"\tTitulo: {Titulo}\n" +
                $"\tPublicação: {AnoPublicacao}\n" +
                $"\tQuantidade disponivel: {Quantidade}\n");
        }
    }
}

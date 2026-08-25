using Biblioteca.Interfaces;

namespace Biblioteca.Classes.Entidades
{
    internal class Livro : ItemBiblioteca
    {
        //Campos
        private string autor;
        private int npaginas;


        //Propriedades
        protected int NumeroDePaginas
        {
            get { return npaginas; }
            set { npaginas = value; }
        }
        protected string AutorLivro
        {
            get { return autor; }
            set { autor = value; }
        }

        //Construtor
        public Livro(string titulo, DateTime anoPublicacao, string autor, int npaginas) : base(titulo, anoPublicacao)
        {
            AutorLivro = autor;
            NumeroDePaginas = npaginas;
        }

        public Livro(int quantidade, DateTime anoPublicacao, string titulo, string autor, int npaginas) : base(quantidade, anoPublicacao, titulo)
        {
            AutorLivro = autor;
            NumeroDePaginas = npaginas;
        }

        //Métodos
        public override string Exibir()
        {
            return base.Exibir() + "" +
                $"\t Autor do livro: {AutorLivro}\n" +
                $"\t N° de páginas: {NumeroDePaginas}\n";
        }
    }
}

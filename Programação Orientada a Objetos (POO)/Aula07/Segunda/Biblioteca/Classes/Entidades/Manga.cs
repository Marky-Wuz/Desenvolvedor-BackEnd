using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.Classes.Entidades
{
    internal class Manga : ItemBiblioteca
    {
        //Campos
        private int ndomanga;
        private string mesdepublicacao;


        //Propriedades
        protected int PaginasManga
        {
            get { return ndomanga; }
            set { ndomanga = value; }
        }
        protected string MesDaPublicacao
        {
            get { return mesdepublicacao; }
            set { mesdepublicacao = value; }
        }

        //Construtor
        public Manga(string titulo, DateTime anoPublicacao, int ndomanga, string mesdepublicacao) : base(titulo, anoPublicacao)
        {
            PaginasManga = ndomanga;
            MesDaPublicacao = mesdepublicacao;
        }

        public Manga(int quantidade, DateTime anoPublicacao, string titulo, int ndomanga, string mesdepublicacao) : base(quantidade, anoPublicacao, titulo)
        {
            PaginasManga = ndomanga;
            MesDaPublicacao = mesdepublicacao;
        }

        //Métodos
        public override string Exibir()
        {
            return base.Exibir() + "" +
                $"\t Paginas do Manga: {PaginasManga}\n" +
                $"\t Mes de Publicacação: {MesDaPublicacao}\n";
        }
    }
}
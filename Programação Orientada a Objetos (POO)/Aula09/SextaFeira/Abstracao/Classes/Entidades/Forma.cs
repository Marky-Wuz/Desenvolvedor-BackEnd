using Abstracao.Enumeracoes;
using Abstracao.Interfaces;

namespace Abstracao.Classes.Entidades
{
    abstract internal class Forma : IGeometria
    {
        // Campo
        Cor cor;


        //Construtor
        protected Forma(Cor cor)
        {
            this.cor = cor;
        }

        //Método
        public abstract void Area();

        public void Cor()
        {
            Console.WriteLine(cor.ToString());
        }
    }
}

using Abstracao.Enumeracoes;

namespace Abstracao.Classes.Entidades
{
    internal class Retangulo : Forma
    {
        //Campos
        private double altura;
        private double largura;


        //Propriedades
        protected double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        protected double Largura
        {
            get { return largura; }
            set { largura = value; }
        }


        //Construtor
        public Retangulo(Cor cor, double largura, double altura) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        //Métodos
        public override void Area()
        {
            Console.WriteLine(Largura * Altura);
        }
    }
}

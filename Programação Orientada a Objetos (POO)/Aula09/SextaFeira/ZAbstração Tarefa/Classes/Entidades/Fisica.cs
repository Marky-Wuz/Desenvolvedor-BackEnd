namespace ZAbstração_Tarefa.Classes.Entidades
{
    internal class Fisica : Impostos
    {
        //Campos
        private double saude;

        //Propriedade
        protected double GastosComSaude
        {
            get { return saude; }
            set { saude = value; }
        }

        //Construtor
        public Fisica(double rendaAnual, string nome, double saude) : base(rendaAnual, nome)
        {
            GastosComSaude = saude;
        }

        //Métodos
        public override double Imposto()
        {
            return base.Imposto() - GastosComSaude * 0.5;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Gastos Com Saúde: {GastosComSaude}\n" +
                $"\tImpostos: {base.Imposto()}" +
                $"\tTotal: {Imposto()}\n");
        }

    }
}

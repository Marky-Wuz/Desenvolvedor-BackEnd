namespace Pessoas.Classes.Entidades
{
    internal class Terceiro : Funcionario
    {
        private double despesa;

        //Propriedades
        protected double DespesaAdicional
        {
            get { return despesa; }
            set { despesa = value; }
        }

        //Construtores
        public Terceiro(double valorPorHora, int jornadaDoFuncionario, string nomeDoFuncionario) : base(valorPorHora, jornadaDoFuncionario, nomeDoFuncionario)
        {
            DespesaAdicional = (ValorPorHora * JornadaDoFuncionario) * 0.2;
        }

        //Métodos
        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdicional;
        }

    }
}

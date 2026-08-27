namespace Master.Classes.Entidades
{
    internal class ContaPoupanca : Conta
    {
        //Campos
        private double taxa;

        //propriedades
        protected double TaxaDeJuros
        {
            get { return taxa; }
            set { taxa = value / 100; }
        }

        //Construtores
        public ContaPoupanca(int numeroDaConta, string titularDaConta, double taxa) : base(numeroDaConta, titularDaConta)
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupanca(int numeroDaConta, string titularDaConta, double saldoDaConta, double taxa) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        //Métodos
        public override void Saque(double qtd)
        {
            SaldoDaConta = qtd + (qtd * taxa);
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"\tJuros Aplicados: {TaxaDeJuros * 100:f2}");
        }

    }
}

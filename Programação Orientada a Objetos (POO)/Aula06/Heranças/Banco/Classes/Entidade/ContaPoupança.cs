namespace Banco.Classes.Entidade
{
    internal sealed class ContaPoupança : Conta
    {
		// Campos
		private double taxa;


        //Propriedades
        public double TaxaDeJuros
		{
			get { return taxa; }
			set { taxa = value; }
		}

        //Construtores
        public ContaPoupança(string titularDaConta, int numeroDaConta, double taxa) : base(titularDaConta, numeroDaConta)
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupança(int numeroDaConta, string titularDaConta, double saldoDaConta, double taxa) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            TaxaDeJuros = taxa;
        }

        // Métodos
        public override void Saque(double quantia)
        {
            SaldoDaConta -= quantia + (quantia * TaxaDeJuros);
        }

        public void AtualizaçãoDeSaldo()
        {
            Console.WriteLine($"O seu saldo atualizou para {SaldoDaConta}");
        }
             public override string ToString()
        {
            return "$Dados da conta:\n" +
                $"\tTitular: {TitularDaConta}\n" +
                $"\tNúmero: {NumeroDaConta}\n" +
                $"\tSaldo: {SaldoDaConta:c}\n";
        }
	}
}

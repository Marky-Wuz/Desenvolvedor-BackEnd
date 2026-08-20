namespace Banco.Classes.Entidades
{
    internal class ContaPessoaFisica
    {
		// 1° Campos
		private int Numero;
		private string titular;
		private double saldo;

		// 2° Propriedade
        protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		protected int NumeroDaConta
		{
			get { return Numero; }
			set { Numero = value; }
		}

		protected string TitularDaConta
		{
			get { return titular; }
			set { titular = value; }
		}

		//3° Construtor
        public ContaPessoaFisica(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
			SaldoDaConta = 0;
        }

        public ContaPessoaFisica(double saldoDaConta, int numeroDaConta, string titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        //4° Métodos
		public void Saque(double quantia)
		{
			SaldoDaConta -= quantia;
		}
		public void Deposito(double quantia)
		{
			SaldoDaConta += quantia;
		}

    }
}

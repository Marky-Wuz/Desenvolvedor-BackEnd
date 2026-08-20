namespace Banco.Classes.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica      
    {
		//Campo
		private double limite;


        //Propriedade
        public double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}

		//Construtor
        public ContaPessoaJuridica(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDaConta = limite;
        }

        public ContaPessoaJuridica(double saldoDaConta, int numeroDaConta, string titularDaConta, double limite) : base(saldoDaConta, numeroDaConta, titularDaConta)
        {
            LimiteDaConta = limite;
        }

        public void Limite(double quantia)
        {
            SaldoDaConta += quantia;
        }
	}
}

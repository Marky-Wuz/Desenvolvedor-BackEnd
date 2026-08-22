namespace Banco.Classes.Entidade
{
    internal class ContaEmpresa : Conta
    {
		// Campos
		private double limite;


        // Propriedades
        protected double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}
        
        // Construtores
        public ContaEmpresa(string titularDaConta, int numeroDaConta, double limite) : base(titularDaConta, numeroDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(titularDaConta, numeroDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }
        
        // Métodos
        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }

        public override string ToString()
        {
            return "$Dados da conta:\n" +
                $"\tTitular: {TitularDaConta}\n" +
                $"\tNúmero: {NumeroDaConta}\n" +
                $"\tSaldo: {SaldoDaConta:c}\n" +
                $"\tLimite: {LimiteDeEmprestimo:c}\n";
        }
	}
}

namespace Master.Classes.Entidades
{
    internal class ContaEmpresa : Conta
    {
        //Campos
        private double limite;


        //Propriedades
        protected double LimiteEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }
        //Construtores
        public ContaEmpresa(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteEmprestimo = limite;
        }

        //Métodos
        public void Emprestimo(double qtd)
        {
            LimiteEmprestimo -= qtd;
            SaldoDaConta += qtd;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Limite de Emprestimos: {LimiteEmprestimo}\n");
        }

    }
}

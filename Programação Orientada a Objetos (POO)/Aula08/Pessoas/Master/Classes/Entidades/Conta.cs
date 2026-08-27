using Master.Interfaces;

namespace Master.Classes.Entidades
{
    internal class Conta : IOperacoes
    {
        //Campos
        private string titular;
        private int numero;
        private double saldo;



        //Propriedades
        public double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }

        protected string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }

        //Construtores
        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = 0;
        }
        public Conta(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }
        //Métodos
        public void Deposito(double qtd)
        {
            SaldoDaConta += qtd;
        }

        public virtual void Saque(double qtd)
        {
            SaldoDaConta -= qtd;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Titular da Conta: {TitularDaConta}\n" +
                $"\tSaldo da Conta: {SaldoDaConta:c}\n" +
                $"\tNumero da Conta: {NumeroDaConta}\n");
        }
    }
}

using Banco.Interfaces;

namespace Banco.Classes.Entidade
{
    internal class Conta : IOperacoes
    {
        // 1° Campos
        private int numero;
        private string titular;
        private double saldo;


        // 2° Propriedade
        public double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string TitularDaConta
        {
            get { return titular; }
            set { titular = value; }
        }

        protected int NumeroDaConta
        {
            get { return numero; }
            set { numero = value; }
        }
        // 3° Construtor
        public Conta(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0;
        }

        public Conta(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

        // 4° Metodos

        public virtual void Saque(double quantia)
        {
            SaldoDaConta -= quantia;
        }

        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
    }
}

namespace Banco
{
    public class ContaBancaria
    {
        //1° Campos
        private string titular;
        private int numero;
        private double saldo;


        //2° Propriedades
        protected string TituladorDaConta
        {
            get { return titular; }
            set
            {
                if (value != null | value != "")
                {
                    titular = value;
                }
                else
                {
                    Console.WriteLine("Valor de campo invalido");
                }
            }

        }
        protected int NumerodaConta
        {
            get { return numero; }
            private set { numero = value; }
        }
        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //3° Construtores 
        public ContaBancaria(string tituladorDaConta, int numerodaConta, double saldoDaConta)
        {
            TituladorDaConta = tituladorDaConta;
            NumerodaConta = numerodaConta;
            SaldoDaConta = saldoDaConta;
        }

        public ContaBancaria(string tituladorDaConta, int numerodaConta)
        {
            TituladorDaConta = tituladorDaConta;
            NumerodaConta = numerodaConta;
            SaldoDaConta = 0;
        }

        //4° Metodo
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia < 0)
            {
                Console.WriteLine("Valor invalido, insira valor positivos");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;
            }
        }
        public string ExibirDados()
        {
            return $"Dados da conta:\n" +
                $"\tTitular da conta: {TituladorDaConta}\n" +
                $"\tID da conta: {NumerodaConta}\n " +
                $"\tSaldo da conta: {SaldoDaConta:C}";
        }
    }
}

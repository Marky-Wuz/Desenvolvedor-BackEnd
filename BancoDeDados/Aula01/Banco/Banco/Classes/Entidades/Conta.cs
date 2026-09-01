namespace Banco.Classes.Entidades
{
    internal class Conta
    {
        //Propriedade
        public int Id { get; set; }
        public int NumeroDaConta { get; set; }
        public string TitularDaConta { get; set; }
        public decimal SaldoDaConta { get; set; }

        //Construtores
        private Conta() { }

        public Conta(int numeroDaConta, string titularDaConta, decimal saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
            SaldoDaConta = saldoDaConta;
        }

        //Métodos

        public void Depositar(decimal quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Sacar(decimal quantia)
        {
            SaldoDaConta -= quantia;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Dados da Conta" +
                $"\nNumero da Conta: {NumeroDaConta}" +
                $"\nTitular da Conta: {TitularDaConta}" +
                $"\nSaldo da Conta: {SaldoDaConta:C}" +
                $"\n------------------------------------" +
                $"\nID da conta: {Id}");
        }

    }
}

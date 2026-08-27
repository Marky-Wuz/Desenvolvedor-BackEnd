using Pessoas.Interfaces;

namespace Pessoas.Classes.Entidades
{
    internal class Funcionario : IPagamento
    {
        //Campos
        private string nome;
        private int jornada;
        private double valor;


        //Propriedades

        protected double ValorPorHora
        {
            get { return valor; }
            set { valor = value; }
        }


        protected int JornadaDoFuncionario
        {
            get { return jornada; }
            set { jornada = value; }
        }


        public string NomeDoFuncionario
        {
            get { return nome; }
            set { nome = value; }
        }


        //Construtores
        public Funcionario(double valorPorHora, int jornadaDoFuncionario, string nomeDoFuncionario)
        {
            ValorPorHora = valorPorHora;
            JornadaDoFuncionario = jornadaDoFuncionario;
            NomeDoFuncionario = nomeDoFuncionario;
        }



        // Metodos
        public virtual double Pagamento()
        {
            return JornadaDoFuncionario * ValorPorHora;
        }
    }
}

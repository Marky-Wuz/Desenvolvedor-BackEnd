using ZAbstração_Tarefa.Interfaces;

namespace ZAbstração_Tarefa.Classes.Entidades
{
    internal class Impostos : IAssinatura
    {
        //Campos
        private string nome;
        private double renda;
        private double imposto;


        //Propriedades
        protected double RendaAnual
        {
            get { return renda; }
            set { renda = value; }
        }
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        //Métodos
        public Impostos(double rendaAnual, string nome)
        {
            RendaAnual = rendaAnual;
            Nome = nome;
        }

        public virtual double Imposto()
        {
            if (RendaAnual >= 20000)
            {
                return imposto = RendaAnual * 0.25;
            }
            else  
            {
                return imposto = RendaAnual * 0.15;
            }
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Perfil\n" +
                $"\tNome: {Nome}\n" +
                $"\tRenda: {RendaAnual}\n");
        }
    }
}

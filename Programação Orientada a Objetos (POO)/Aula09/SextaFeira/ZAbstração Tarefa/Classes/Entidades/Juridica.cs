namespace ZAbstração_Tarefa.Classes.Entidades
{
    internal class Juridica : Impostos
    {
        private int funcionario;
        private double imp;
        private double impostoF;


        public int NumeroDeFuncionarios
        {
            get { return funcionario; }
            set { funcionario = value; }
        }

        public Juridica(double rendaAnual, string nome, int funcionario) : base(rendaAnual, nome)
        {
            NumeroDeFuncionarios = funcionario;
        }
        
        public virtual double Quantidade()
        {
            if (funcionario >= 10)
            {
                return impostoF = RendaAnual * 0.14;
            }
            else
            {
                return impostoF = RendaAnual * 0.16;
            }
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Numero de funcionarios: {NumeroDeFuncionarios}\n" +
                $"\tTotal: {Quantidade():c}\n");
        }
    }
}

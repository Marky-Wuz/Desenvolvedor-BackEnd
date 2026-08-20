namespace Contrato.Classes.Entidades
{
    internal class empresas
    {
		//1° Campos
		private string nome;
		private funcionarios funcionario;


        //2° Propriedades
        protected funcionarios Funcionario
		{
			get { return funcionario; }
			set { funcionario = value; }
		}

		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}
		//3° Construtores
        public empresas(string nomeDaEmpresa, string nomeFuncionario)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			Funcionario = new funcionarios(nomeFuncionario);
        }

		//4° Metodos
		public void RegistrarContrato(double valor, int horas)
		{
			Funcionario.AdicionarContrato(valor, horas);
			
        }
	}
}

namespace Pedido.Classes.Entidades
{
    internal class Empresa
    {

		//1° Campos
		private string nome;
		private List<Funcionarios> contratados;


        //2° Propriedades
        protected List<Funcionarios> Listacontratados
		{
			get { return contratados; }
			set { contratados = value; }
		}
		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}
		//3° Construtores
        public Empresa(string nomeDaEmpresa)
        {
            NomeDaEmpresa = nomeDaEmpresa;
			Listacontratados = new List<Funcionarios>();
        }

		//4° - Métodos
		public void AdicionarFuncionario(Funcionarios funcionarios)
		{
			Listacontratados.Add(funcionarios);
		}
	}
}

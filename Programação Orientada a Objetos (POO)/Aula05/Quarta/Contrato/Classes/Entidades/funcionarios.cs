using Contrato.Classes.Contratos;

namespace Contrato.Classes.Entidades
{
    internal class funcionarios
    {
		//1° Campos
		private string nome;
		List<HoraContrato> contratos;


        //2° Propriedade
        protected List<HoraContrato> Contratos
		{
			get { return contratos; }
			set { contratos = value; }
		}

		protected string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

        //3° Construtor	
        public funcionarios(string nome)
        {
            Nome = nome;
        }	

		//4° Metodos
		public void AdicionarContrato(double valor, int horas)
		{
			HoraContrato contrato = new HoraContrato(valor, horas);
			Contratos.Add(contrato);
		}
    }
}


namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
		//1° Campos
		private int horas;
		private double valor;


        //2° Propriedades
        protected double ValorporPonto
		{
			get { return valor; }
			set { valor = value; }
		}
		protected int BaterPonto
		{
			get { return horas; }
			set { horas = value; }
		}

		//3° Construtor
        public HoraContrato(double valorporPonto, int baterPonto)
        {
            ValorporPonto = valorporPonto;
            BaterPonto = baterPonto;
        }

		//4° Metodos
		public double Pagamentos()
		{
			return ValorporPonto * BaterPonto;
		}

	}
}

namespace Pedido.Classes.Entidades
{
    //Objeto que pode existir de forma independente
    internal class Funcionarios
    {
        //1° - Campos
        private string nome;


        //2° - Propriedades
        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        //3° - Construtores
        public Funcionarios(string nome)
        {
            Nome = nome;
        }

    }
}

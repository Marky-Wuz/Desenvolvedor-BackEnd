namespace Restaurante.Classes.Entidades
{
    internal class Pratos
    {
        //Propriedades
        public int Id { get; set; }
        public string Nome_Do_Prato { get; set; }
        public decimal Preco { get; set; }
        public string Foto_Do_Prato { get; set; }

        //Construtor
        public Pratos(string nome_Do_Prato, decimal preco, string foto_Do_Prato)
        {
            Nome_Do_Prato = nome_Do_Prato;
            Preco = preco;
            Foto_Do_Prato = foto_Do_Prato;
        }

        //Métodos

    }
}

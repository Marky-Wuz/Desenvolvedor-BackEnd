
namespace SistemaERP.Classes.Entidades
{
    internal class UltimoUser
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool EsqueceuSenha { get; set; }

        //Construtores
        public UltimoUser(string nome, string senha, bool esqueceuSenha)
        {
            Nome = nome;
            Senha = senha;
            EsqueceuSenha = esqueceuSenha;
        }

        //Métodos
        public void StatusEsqueceuSenha(bool esqueceu)
        {
            EsqueceuSenha = esqueceu;
        }

    }
}

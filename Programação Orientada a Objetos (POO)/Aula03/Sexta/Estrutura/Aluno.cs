using System.Security.Cryptography.X509Certificates;

namespace Estrutura
{
    internal struct Aluno
    {
        //Membros
        //Campos
        public string nome;
        public int cpf;
        public double altura;

        public Aluno(string nome, int cpf) : this()
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        // Construtor
        public Aluno(string nome, int cpf, double altura)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.altura = altura;
        }


            //Métodos
            public double idade(int idade)
        {
            return idade / 365;
        }
    }
}

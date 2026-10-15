using APIPessoas.Model.Entidades;
using Microsoft.EntityFrameworkCore;

namespace APIPessoas.Model.Contextos
{
    public class ProdutosContextos : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"";
            opcoesDeConstrucao.UseSqlite(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Produtos>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NomeDoProduto);
                entidade.Property(e => e.PrecoDoProduto);
                entidade.Property(e => e.Descricao);
                entidade.Property(e => e.Quantidade);

            }

        );
        }



    }
}

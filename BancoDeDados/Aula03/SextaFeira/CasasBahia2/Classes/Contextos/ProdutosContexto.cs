using Microsoft.EntityFrameworkCore;

namespace CasasBahia2.Classes.Contextos
{
    internal class ProdutosContexto : DbContext
    {
        public DbSet<Entidades.Produtos> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OpcoesdeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319376\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            OpcoesdeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modelodeConstrucao)
        {
            modelodeConstrucao.Entity<Entidades.Produtos>(entidade =>
            {
                entidade.HasKey(e => e.CodigoDoProduto);
                entidade.Property(e => e.NomeDoProduto).IsRequired();
                entidade.Property(e => e.QuantidadeDeProduto).IsRequired();
                entidade.Property(e => e.ValorDoProduto).IsRequired();
            }
            );

        }   
    }
}

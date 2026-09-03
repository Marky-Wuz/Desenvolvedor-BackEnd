using Microsoft.EntityFrameworkCore;

namespace CasasBahia.Classes.Contextos
{
    internal class ProdutoContexto : DbContext
    {
        //Propriedade
        public DbSet<Entidades.Produto> Produtos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder OpcaoDeConstrucao)
        {
            string config = @"Server=ECFP507D1319376\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True";
            OpcaoDeConstrucao.UseSqlServer(config);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Produto>().HasKey(p => p.CodigoDoProduto);
            modelBuilder.Entity<Entidades.Produto>().Property(p => p.NomeDoProduto);
            modelBuilder.Entity<Entidades.Produto>().Property(p => p.ValorDoProduto);
            modelBuilder.Entity<Entidades.Produto>().Property(p => p.QuantidadeDeProduto);

        }
    }
}

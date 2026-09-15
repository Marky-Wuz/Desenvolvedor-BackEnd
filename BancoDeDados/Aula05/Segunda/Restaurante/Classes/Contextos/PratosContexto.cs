using Microsoft.EntityFrameworkCore;
using Restaurante.Classes.Entidades;

namespace Restaurante.Classes.Contextos
{
    internal class PratosContexto :DbContext
    {
        //propriedade
        public DbSet<Entidades.Pratos> Pratos { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319376\SQLEXPRESS01;Database=Sensei;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Pratos>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Nome_Do_Prato);
                entidade.Property(e => e.Preco);
                entidade.Property(e => e.Foto_Do_Prato);
            }

        );
        }


    }
}

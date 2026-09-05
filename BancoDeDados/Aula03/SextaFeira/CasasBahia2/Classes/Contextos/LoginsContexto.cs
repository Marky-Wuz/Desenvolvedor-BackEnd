using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Contextos
{
    internal class LoginsContexto : DbContext
    {
        public DbSet<Entidades.Logins> Logins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OpcoesdeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319376\SQLEXPRESS01;Database=ProdutosCasasBahia;Trusted_Connection=True;TrustServerCertificate=True;";
            OpcoesdeConstrucao.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modelodeConstrucao)
        {
            modelodeConstrucao.Entity<Entidades.Logins>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Usuario).IsRequired();
                entidade.Property(e => e.Senha).IsRequired();
                entidade.Property(e => e.Regra).IsRequired();
            }
            );

        }
    }
}

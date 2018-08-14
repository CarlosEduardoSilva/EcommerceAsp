using System.Data.Entity;

namespace EcommerceOsorioManha.Models
{
    public class Contexto : DbContext
    {
        // Nome do Banco
        public Contexto() : base("DbEcommerce") { }

        // Mapear as classes no banco
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasMany(_ => _.Produtos)
                .WithRequired(_ => _.Categoria);
                ;
        }
    }
}
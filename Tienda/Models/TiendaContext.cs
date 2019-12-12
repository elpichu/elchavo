using System;
using Microsoft.EntityFrameworkCore;



namespace Tienda.Models
{
    public class TiendaContext: DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Categoria> Categoria { get; set; }


        public TiendaContext(DbContextOptions<TiendaContext> options):
            base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");



        }


        


    }//End of class
}

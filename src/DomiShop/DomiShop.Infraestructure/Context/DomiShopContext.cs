using DomiShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomiShop.Infrastructure.Context
{
    public class DomiShopContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DomiShopContext(DbContextOptions<DomiShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de Producto
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(p => p.ID_PRODUCTO);
                entity.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Descripcion).HasMaxLength(500);
                entity.Property(p => p.Precio).HasColumnType("decimal(18,2)");
            });

            // Configuración de Categoría
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nombre).IsRequired().HasMaxLength(100);
            });
        }
    }
}

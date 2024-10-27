using Microsoft.EntityFrameworkCore;
using DomiShop.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DomiShop.Infrastructure
{
    public class DomiShopContext : DbContext
    {
        public DomiShopContext(DbContextOptions<DomiShopContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("productos");
        }
    }
}

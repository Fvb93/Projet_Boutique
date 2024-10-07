using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Boutique.DAL.Entities;
using Projet_Boutique.DAL.DataBase.Configurations;
using Projet_Boutique.DAL.DataBase.Data;

namespace Projet_Boutique.DAL.DataBase
{
    public class BoutiqueContext : DbContext
    {
        public BoutiqueContext(DbContextOptions<BoutiqueContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<FormatProduct> FormatProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CategoryProductConfig());
            modelBuilder.ApplyConfiguration(new FormatConfig());
            modelBuilder.ApplyConfiguration(new FormatProductConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderProductConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new DataProduct());
            modelBuilder.ApplyConfiguration(new DataCategory());
            modelBuilder.ApplyConfiguration(new DataCategoryProduct());
        }
    }
}

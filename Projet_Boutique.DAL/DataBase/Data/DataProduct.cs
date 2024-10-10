using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Boutique.DAL.Entities;

namespace Projet_Boutique.DAL.DataBase.Data
{
    public class DataProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200, Stock = 10, TVA = 21},
            new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 800, Stock = 20, TVA = 21},
            new Product { Id = 3, Name = "Wireless Headphones", Description = "Noise cancelling headphones", Price = 200, Stock = 50, TVA = 21},
            new Product { Id = 4, Name = "Coffee Maker", Description = "Automatic coffee machine", Price = 150, Stock = 30, TVA = 21},
            new Product { Id = 5, Name = "Electric Kettle", Description = "Fast boiling kettle", Price = 50, Stock = 60, TVA = 21},
            new Product { Id = 6, Name = "Blender", Description = "High-speed blender", Price = 100, Stock = 40, TVA = 21},
            new Product { Id = 7, Name = "Vacuum Cleaner", Description = "Cordless vacuum cleaner", Price = 250, Stock = 25, TVA = 21},
            new Product { Id = 8, Name = "Gaming Console", Description = "Latest generation console", Price = 500, Stock = 15, TVA = 21},
            new Product { Id = 9, Name = "Smartwatch", Description = "Waterproof fitness smartwatch", Price = 150, Stock = 35, TVA = 21},
            new Product { Id = 10, Name = "4K TV", Description = "Ultra HD 4K smart TV", Price = 900, Stock = 10, TVA = 21},
            new Product { Id = 11, Name = "Refrigerator", Description = "Energy-efficient refrigerator", Price = 1200, Stock = 8, TVA = 21},
            new Product { Id = 12, Name = "Washing Machine", Description = "Front load washing machine", Price = 800, Stock = 12, TVA = 21},
            new Product { Id = 13, Name = "Dishwasher", Description = "Automatic dishwasher", Price = 700, Stock = 10, TVA = 21},
            new Product { Id = 14, Name = "Microwave Oven", Description = "Compact microwave oven", Price = 200, Stock = 40, TVA = 21},
            new Product { Id = 15, Name = "Camera", Description = "Digital camera with 4K video", Price = 1100, Stock = 15, TVA = 21},
            new Product { Id = 16, Name = "Speakers", Description = "Bluetooth wireless speakers", Price = 300, Stock = 25, TVA = 21},
            new Product { Id = 17, Name = "Router", Description = "WiFi 6 router", Price = 150, Stock = 50, TVA = 21},
            new Product { Id = 18, Name = "Tablet", Description = "High-resolution tablet", Price = 600, Stock = 20, TVA = 21},
            new Product { Id = 19, Name = "Printer", Description = "All-in-one wireless printer", Price = 200, Stock = 30, TVA = 21},
            new Product { Id = 20, Name = "Air Conditioner", Description = "Portable air conditioner", Price = 700, Stock = 10, TVA = 21}
                );  
        }
    }
}

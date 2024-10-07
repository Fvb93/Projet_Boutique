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
            new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200f, Stock = 10, TVA = 21.0f },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 800f, Stock = 20, TVA = 21.0f },
            new Product { Id = 3, Name = "Wireless Headphones", Description = "Noise cancelling headphones", Price = 200f, Stock = 50, TVA = 21.0f },
            new Product { Id = 4, Name = "Coffee Maker", Description = "Automatic coffee machine", Price = 150f, Stock = 30, TVA = 21.0f },
            new Product { Id = 5, Name = "Electric Kettle", Description = "Fast boiling kettle", Price = 50f, Stock = 60, TVA = 21.0f },
            new Product { Id = 6, Name = "Blender", Description = "High-speed blender", Price = 100f, Stock = 40, TVA = 21.0f },
            new Product { Id = 7, Name = "Vacuum Cleaner", Description = "Cordless vacuum cleaner", Price = 250f, Stock = 25, TVA = 21.0f },
            new Product { Id = 8, Name = "Gaming Console", Description = "Latest generation console", Price = 500f, Stock = 15, TVA = 21.0f },
            new Product { Id = 9, Name = "Smartwatch", Description = "Waterproof fitness smartwatch", Price = 150f, Stock = 35, TVA = 21.0f },
            new Product { Id = 10, Name = "4K TV", Description = "Ultra HD 4K smart TV", Price = 900f, Stock = 10, TVA = 21.0f },
            new Product { Id = 11, Name = "Refrigerator", Description = "Energy-efficient refrigerator", Price = 1200f, Stock = 8, TVA = 21.0f },
            new Product { Id = 12, Name = "Washing Machine", Description = "Front load washing machine", Price = 800f, Stock = 12, TVA = 21.0f },
            new Product { Id = 13, Name = "Dishwasher", Description = "Automatic dishwasher", Price = 700f, Stock = 10, TVA = 21.0f },
            new Product { Id = 14, Name = "Microwave Oven", Description = "Compact microwave oven", Price = 200f, Stock = 40, TVA = 21.0f },
            new Product { Id = 15, Name = "Camera", Description = "Digital camera with 4K video", Price = 1100f, Stock = 15, TVA = 21.0f },
            new Product { Id = 16, Name = "Speakers", Description = "Bluetooth wireless speakers", Price = 300f, Stock = 25, TVA = 21.0f },
            new Product { Id = 17, Name = "Router", Description = "WiFi 6 router", Price = 150f, Stock = 50, TVA = 21.0f },
            new Product { Id = 18, Name = "Tablet", Description = "High-resolution tablet", Price = 600f, Stock = 20, TVA = 21.0f },
            new Product { Id = 19, Name = "Printer", Description = "All-in-one wireless printer", Price = 200f, Stock = 30, TVA = 21.0f },
            new Product { Id = 20, Name = "Air Conditioner", Description = "Portable air conditioner", Price = 700f, Stock = 10, TVA = 21.0f }
                );  
        }
    }
}

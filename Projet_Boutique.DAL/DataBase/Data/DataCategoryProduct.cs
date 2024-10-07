using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.DataBase.Data
{
    public class DataCategoryProduct : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasData(
           new CategoryProduct { ProductId = 1, CategoryId = 1 }, // Laptop -> Électronique
           new CategoryProduct { ProductId = 1, CategoryId = 4 }, // Laptop -> Informatique
           new CategoryProduct { ProductId = 2, CategoryId = 1 }, // Smartphone -> Électronique
           new CategoryProduct { ProductId = 3, CategoryId = 3 }, // Wireless Headphones -> Accessoires
           new CategoryProduct { ProductId = 4, CategoryId = 6 }, // Coffee Maker -> Électroménager
           new CategoryProduct { ProductId = 5, CategoryId = 6 }, // Electric Kettle -> Électroménager
           new CategoryProduct { ProductId = 6, CategoryId = 6 },  // Blender -> Électroménager
           new CategoryProduct { ProductId = 7, CategoryId = 6 },  // Vacuum Cleaner -> Électroménager
           new CategoryProduct { ProductId = 8, CategoryId = 5 },  // Gaming Console -> Gaming
           new CategoryProduct { ProductId = 9, CategoryId = 3 },  // Smartwatch -> Accessoires
           new CategoryProduct { ProductId = 10, CategoryId = 1 }, // 4K TV -> Électronique
           new CategoryProduct { ProductId = 11, CategoryId = 6 }, // Refrigerator -> Électroménager
           new CategoryProduct { ProductId = 12, CategoryId = 6 }, // Washing Machine -> Électroménager
           new CategoryProduct { ProductId = 13, CategoryId = 6 }, // Dishwasher -> Électroménager
           new CategoryProduct { ProductId = 14, CategoryId = 6 }, // Microwave Oven -> Électroménager
           new CategoryProduct { ProductId = 15, CategoryId = 1 }, // Camera -> Électronique
           new CategoryProduct { ProductId = 16, CategoryId = 3 }, // Speakers -> Accessoires
           new CategoryProduct { ProductId = 17, CategoryId = 4 }, // Router -> Informatique
           new CategoryProduct { ProductId = 18, CategoryId = 1 }, // Tablet -> Électronique
           new CategoryProduct { ProductId = 19, CategoryId = 4 }, // Printer -> Informatique
           new CategoryProduct { ProductId = 20, CategoryId = 6 }  // Air Conditioner -> Électroménager
           );
        }
    }
}

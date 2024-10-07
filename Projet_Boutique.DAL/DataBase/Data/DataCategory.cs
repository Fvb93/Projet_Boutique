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
    public class DataCategory : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Électronique" },
                new Category { Id = 2, Name = "Appareils ménagers" },
                new Category { Id = 3, Name = "Accessoires" },
                new Category { Id = 4, Name = "Informatique" },
                new Category { Id = 5, Name = "Gaming" },
                new Category { Id = 6, Name = "Électroménager" }
            );
        }
    }
}

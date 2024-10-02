using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.DataBase.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Propriétés
            builder.ToTable("Categorie");

            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired();
            #endregion

            #region Contraintes 
            builder.HasKey(c => c.Id)
                .HasName("PK_Category");
            #endregion

        }
    }
}

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
    public class FormatConfig : IEntityTypeConfiguration<Format>
    {
        public void Configure(EntityTypeBuilder<Format> builder)
        {
            #region Propriétés
            builder.ToTable("Format");

            builder.Property(f => f.Id)
                .IsRequired();

            builder.Property(f => f.Unit)
                .IsRequired();

            builder.Property(f => f.Quantity)
                .IsRequired();
            #endregion

            #region Contraintes 
            builder.HasKey(f => f.Id)
                .HasName("PK_Format");
            #endregion
        }
    }
}

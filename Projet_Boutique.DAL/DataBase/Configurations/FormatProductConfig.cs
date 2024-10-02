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
    public class FormatProductConfig : IEntityTypeConfiguration<FormatProduct>
    {
        public void Configure(EntityTypeBuilder<FormatProduct> builder)
        {
            #region Propriétés
            builder.ToTable("Format_Produit_NN");

            builder.Property(op => op.Stock)
                .IsRequired();
            #endregion

            #region Contraintes
            builder.HasKey(fp => new { fp.FormatId, fp.ProductId });
            #endregion

            #region Relations
            builder.HasOne(format => format.Format)
                .WithMany(product => product.ProductsList)
                .HasForeignKey(format => format.FormatId);

            builder.HasOne(product => product.Product)
                .WithMany(format => format.FormatsList)
                .HasForeignKey(product => product.ProductId);
            #endregion
        }
    }
}

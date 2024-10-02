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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            #region Propriétés
            builder.ToTable("Commande");

            builder.Property(o => o.Id)
                .IsRequired();

            builder.Property(o => o.TransactionDate)
                .IsRequired();

            builder.Property(o => o.Amount)
                .IsRequired();
            #endregion

            #region Contraintes 
            builder.HasKey(o => o.Id)
                .HasName("PK_Order");
            #endregion

            #region Relations
            builder.HasOne(o => o.OrderUser)
                .WithMany(user => user.OrderList);
            #endregion
        }
    }
}

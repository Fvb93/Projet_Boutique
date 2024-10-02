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
    public class OrderProductConfig : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            #region Propriétés
            builder.ToTable("Commande_Produit_NN");

            builder.Property(op => op.AmountHTVA)
                .IsRequired();

            builder.Property(op => op.AmountTVAC)
                .IsRequired();
            #endregion

            #region Contraintes
            builder.HasKey(op => new { op.ProductId, op.OrderId });
            #endregion

            #region Relations
            // Une commande à plusieurs produits
            builder.HasOne(order => order.Order)
                .WithMany(product => product.ProductList)
                .HasForeignKey(order => order.OrderId);
            // Un produit est dans plusieurs commandes
            builder.HasOne(product => product.Product)
                .WithMany(order => order.OrderList)
                .HasForeignKey(product => product.ProductId);
            #endregion
        }
    }
}

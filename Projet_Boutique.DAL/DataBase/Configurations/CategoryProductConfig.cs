using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.DataBase.Configurations
{
public class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
{
    public void Configure(EntityTypeBuilder<CategoryProduct> builder)
    {
        #region Propriétés
            builder.ToTable("Categorie_Produit_NN");
        #endregion

        #region Contraintes
        builder.HasKey(cp => new { cp.ProductId, cp.CategoryId });
        #endregion

        #region Relations
        // Une catégorie à plusieurs produits
        builder.HasOne(category => category.Category)
            .WithMany(product => product.ProductsList)
            .HasForeignKey(category => category.CategoryId);
        // Un produit à plusieurs catégories
        builder.HasOne(product => product.Product)
            .WithMany(category => category.CategoriesList)
            .HasForeignKey(product => product.ProductId);
        #endregion
    }
}
}

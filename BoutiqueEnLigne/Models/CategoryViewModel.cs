using Projet_Boutique.DAL.Entities;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nom de la catégorie :")]
        public string Name { get; set; }
        [DisplayName("Categorie du produit :")]
        public ICollection<CategoryProduct>? ProductsFK { get; set; }
    }
}
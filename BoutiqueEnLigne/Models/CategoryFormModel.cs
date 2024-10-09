using Projet_Boutique.DAL.Entities;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class CategoryFormModel
    {
        public int Id { get; set; }
        [DisplayName("Nom du produit :")]
        public string Name { get; set; }
        [DisplayName("Description du produit :")]
        public ICollection<CategoryProduct>? ProductList { get; set; }
    }
}

using Projet_Boutique.DAL.Entities;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class CategoryFormModel
    {
        public int Id { get; set; }
        [DisplayName("Nom de la catégorie :")]
        public string Name { get; set; } 
        public ICollection<CategoryProduct>? ProductList { get; set; }
        public bool IsSelected { get; set; } 
    }
}

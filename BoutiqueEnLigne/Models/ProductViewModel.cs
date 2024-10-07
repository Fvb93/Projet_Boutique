using Projet_Boutique.DAL.Entities;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nom du produit :")]
        public string Name { get; set; }
        [DisplayName("Description du produit :")]
        public string? Description { get; set; }
        [DisplayName("Prix :")]
        public float Price { get; set; }
        [DisplayName("Disponibilité :")]
        public bool StockDispo { get; set; }
        public int Stock { get; set; }
    }
}

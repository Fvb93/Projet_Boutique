using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Models
{
    public class ProductFormModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Nom")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Prix")]
        [Range(1, 10000, ErrorMessage = "Le prix doit être compris entre 1 et 10000")]
        [Required]
        public decimal Price { get; set; }
        [DisplayName("Stock")]
        public int Stock { get; set; } = 0;
        [DisplayName("TVA")]
        public decimal TVA { get; set; } = 21;
        [DisplayName("Categories")]
        public List<CategoryFormModel> Categories { get; set; } = new List<CategoryFormModel>();
        [DisplayName("Categorie du produit :")]
        public ICollection<CategoryProduct>? CategoriesList { get; set; }
    }
}


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
        [Required]
        public float Price { get; set; }
        [DisplayName("Stock")]
        public int Stock { get; set; } = 0;
        [DisplayName("TVA")]
        public float TVA { get; set; } = 0.21f;
    }
}


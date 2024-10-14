using Projet_Boutique.DAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class UserFormModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Nom")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Prénom")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "L'adresse email est requise.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "L'adresse email n'est pas valide.")]
        public string Email { get; set; }
        [DisplayName("Mot de passe")]
        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Le {0} doit contenir au moins {2} caractères.", MinimumLength = 6)]
        public string Password { get; set; }
        [DisplayName("Confirmer le mot de passe")]
        [Required(ErrorMessage = "La confirmation est requise.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Le mot de passe et la confirmation ne correspondent pas.")]
        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "La date de naissance est requise.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date de naissance")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Liste de commande")]
        public List<Order> Orders { get; set; } = new List<Order>();
        [DisplayName("Droit administrateur")]
        public bool Admin { get; set; } 

    }
}

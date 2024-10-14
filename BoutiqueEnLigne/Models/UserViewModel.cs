using Projet_Boutique.DAL.Entities;
using System.ComponentModel;

namespace BoutiqueEnLigne.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nom :")]
        public string Name { get; set; }
        [DisplayName("Prénom :")]
        public string FirstName { get; set; }
        [DisplayName("Email :")]
        public string Email { get; set; }
        [DisplayName("Date de naissance :")]
        public DateTime Birthdate { get; set; }
        [DisplayName("Commandes associées :")]
        public IEnumerable<Order>? OrderList { get; set; }
    }
}

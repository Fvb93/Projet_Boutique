using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public IEnumerable<Order>? OrderList { get; set; }
    }
}

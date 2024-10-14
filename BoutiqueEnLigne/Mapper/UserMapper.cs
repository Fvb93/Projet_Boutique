using BoutiqueEnLigne.Models;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Mapper
{
    public static class UserMapper
    {
        public static UserViewModel ToViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                FirstName = user.FirstName,
                Email = user.Email,
                Birthdate = user.BirthDate,
                OrderList = user.OrderList
            };
        }
        public static UserFormModel ToFormModel(this User user)
        {
            return new UserFormModel
            {
                Id = user.Id,
                Name = user.Name,
                FirstName = user.FirstName,
                Email = user.Email,
                BirthDate = user.BirthDate,
                Password = user.Password,
                Admin = user.Admin,
                Orders = user.OrderList
            };
        }
        public static User FromFormtoProduct(this UserFormModel userViewModel)
        {
            return new User
            {
                Id = userViewModel.Id,
                Name = userViewModel.Name,
                FirstName = userViewModel.FirstName,
                Email = userViewModel.Email,
                BirthDate = userViewModel.BirthDate,
                Password = userViewModel.Password,
                Admin = userViewModel.Admin,
                OrderList = userViewModel.Orders
            };
        }
    }
}

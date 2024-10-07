using BoutiqueEnLigne.Models;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Mapper
{
    public static class CategoryMapper
    {
        public static CategoryViewModel ToViewModel(this Category categorie)
        {
            return new CategoryViewModel
            {
                Id = categorie.Id,
                Name = categorie.Name
            };
        }
        public static ProductFormModel ToFormModel(this Category categorie)
        {
            return new ProductFormModel
            {
                Id = categorie.Id,
                Name = categorie.Name
            };
        }
        public static Category FromFormtoCategory(this ProductFormModel categoerieViewModel)
        {
            return new Category
            {
                Id = categoerieViewModel.Id,
                Name = categoerieViewModel.Name
            };
        }
    }
}

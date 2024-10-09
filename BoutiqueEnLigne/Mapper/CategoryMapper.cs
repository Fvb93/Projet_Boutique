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
                Name = categorie.Name,
                ProductsFK = categorie.ProductsList
            };
        }
        public static CategoryFormModel ToFormModel(this Category categorie)
        {
            return new CategoryFormModel
            {
                Id = categorie.Id,
                Name = categorie.Name
            };
        }
        public static Category FromFormtoCategory(this CategoryFormModel categorieViewModel)
        {
            return new Category
            {
                Id = categorieViewModel.Id,
                Name = categorieViewModel.Name
            };
        }
    }
}

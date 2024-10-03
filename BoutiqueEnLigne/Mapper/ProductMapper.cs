using BoutiqueEnLigne.Models;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Mapper
{
    public static class ProductMapper
    {
        public static ProductViewModel toViewModel(this Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockDispo = product.Stock > 0 ? true : false
            };
        }
    }
}

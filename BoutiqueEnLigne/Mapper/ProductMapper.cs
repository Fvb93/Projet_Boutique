using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Projet_Boutique.DAL.Entities;
using System;

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
        public static ProductFormModel toFormModel(this Product product)
        {
                return new ProductFormModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    TVA = product.TVA
                };
        }
        public static Product fromFormtoProduct(this ProductFormModel productViewModel)
        {
                return new Product
                {
                    Id = productViewModel.Id,
                    Name = productViewModel.Name,
                    Description = productViewModel.Description,
                    Price = productViewModel.Price,
                    Stock = productViewModel.Stock,
                    TVA = productViewModel.TVA
                };
        }
    }
}

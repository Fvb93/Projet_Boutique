using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Boutique.BLL.Models.Exceptions;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;
using Projet_Boutique.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public bool Create(Product entity)
        {
            return _repo.Create(entity);
        }
        public void Delete(Product entity)
        {
            Product? product = _repo.GetById(entity.Id);
            if (product is null)
            {
                throw new ProductNotFoundException($"Aucune produit n'a été trouvé, suppression impossible");
            }
        }
        public List<Product> GetAll()
        {
            return _repo.GetAll();
        }
        public Product GetById(int key)
        {
            Product? product = _repo.GetById(key);

            if (product is null)
            {
                throw new ProductNotFoundException($"Aucune personne n'a été trouvé avec l'id {key}");
            }

            return product;
        }
        public Product GetByName(string key)
        {
            Product? product = _repo.GetByName(key);

            if (product is null)
            {
                throw new ProductNotFoundException($"Aucune personne n'a été trouvé avec le nom {key}");
            }

            return product;
        }
        public bool Update(Product entity)
        {
            return _repo.Update(entity);
        }
    }
}

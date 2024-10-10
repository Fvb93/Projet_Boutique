using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Projet_Boutique.DAL.DataBase;
using Projet_Boutique.DAL.Entities;
using Projet_Boutique.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BoutiqueContext _context;
        public ProductRepository(BoutiqueContext context)
        {
            _context = context;
        }
        public bool Create(Product entity)
        {
            Product product = _context.Products.Add(entity).Entity;
            if (product != null)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Create(Product entity, List<int> categorieIds)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();

            foreach (var categoryId in categorieIds)
            {
                if (categoryId != null)
                {
                    entity.CategoriesList.Add(new CategoryProduct { CategoryId = categoryId});
                    _context.SaveChanges();
                }
            }
                    return true;
        }
        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return _context.Products.Include(c => c.CategoriesList).ThenInclude(cp => cp.Category).ToList();
        }
        public Product? GetById(int key)
        {
            return _context.Products.Include(c => c.CategoriesList).ThenInclude(cp => cp.Category).FirstOrDefault(p => p.Id == key);
        }
        public Product? GetByName(string key)
        {
            return _context.Products.Include(c => c.CategoriesList).ThenInclude(cp => cp.Category).FirstOrDefault(p => p.Name.Contains(key));
        }
        public bool Update(Product entity)
        {
           Product? product = _context.Products.Include(c => c.CategoriesList).ThenInclude(cp => cp.Category).FirstOrDefault(p => p.Id == entity.Id);
            if (product != null)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.TVA = entity.TVA;
                product.Price = entity.Price;
                product.Stock = entity.Stock;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

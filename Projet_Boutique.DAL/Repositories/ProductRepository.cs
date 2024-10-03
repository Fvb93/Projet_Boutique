﻿using Microsoft.EntityFrameworkCore.Diagnostics;
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
        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product? GetById(int key)
        {
            return _context.Products.FirstOrDefault(p => p.Id == key);
        }
        public Product? GetByName(string key)
        {
            return _context.Products.FirstOrDefault(p => p.Name.Contains(key));
        }
        public bool Update(Product entity)
        {
           Product? product = _context.Products.FirstOrDefault(p => p.Id == entity.Id);
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

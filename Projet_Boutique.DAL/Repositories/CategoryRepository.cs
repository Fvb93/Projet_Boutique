﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BoutiqueContext _context;
        public CategoryRepository(BoutiqueContext context)
        {
            _context = context;
        }
        public bool Create(Category entity)
        {
            Category categorie = _context.Categories.Add(entity).Entity;
            if (categorie != null)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
        public Category? GetById(int key)
        {
            return _context.Categories.FirstOrDefault(p => p.Id == key);
        }
        public Category? GetByName(string key)
        {
            {
                return _context.Categories.FirstOrDefault(p => p.Name.Contains(key));
            }
        }
        public bool Update(Category entity)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.Id == entity.Id);
            if (product != null)
            {
                product.Name = entity.Name;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

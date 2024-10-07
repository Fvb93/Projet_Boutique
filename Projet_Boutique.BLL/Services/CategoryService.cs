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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        public CategoryService (ICategoryRepository repo)
        {
            _repo = repo;
        }
        public bool Create(Category entity)
        {
            return _repo.Create(entity);
        }
        public void Delete(Category entity)
        {
            Category? categorie = _repo.GetById(entity.Id);
            if (categorie is null)
            {
                throw new ProductNotFoundException($"Aucune catégorie n'a été trouvée, suppression impossible");
            }
            _repo.Delete(entity);
        }
        public List<Category> GetAll()
        {
            return _repo.GetAll();
        }
        public Category GetById(int key)
        {
            Category? categorie = _repo.GetById(key);

            if (categorie is null)
            {
                throw new ProductNotFoundException($"Aucune catégorie n'a été trouvée avec l'id {key}");
            }

            return categorie;
        }
        public Category GetByName(string key)
        {
            Category? categorie = _repo.GetByName(key);

            if (categorie is null)
            {
                throw new ProductNotFoundException($"Aucune catégorie n'a été trouvée avec le nom {key}");
            }

            return categorie;
        }
        public bool Update(Category entity)
        {
            return _repo.Update(entity);
        }
    }
}

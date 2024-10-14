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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public bool Create(User entity)
        {
            return _repo.Create(entity);
        }
        public void Delete(User entity)
        {
            User? user = _repo.GetById(entity.Id);
            if (user is null)
            {
                throw new ProductNotFoundException($"Aucun utilisateur n'a été trouvé, suppression impossible");
            }
            _repo.Delete(entity);
        }
        public List<User> GetAll()
        {
            return _repo.GetAll();
        }
        public User GetById(int key)
        {
            User? user = _repo.GetById(key);

            if (user is null)
            {
                throw new ProductNotFoundException($"Aucun utilisateur n'a été trouvé avec l'id {key}");
            }

            return user;
        }
        public User GetByName(string key)
        {
            User? user = _repo.GetByName(key);

            if (user is null)
            {
                throw new ProductNotFoundException($"Aucun utilisateur n'a été trouvé avec le nom {key}");
            }

            return user;
        }
        public bool Update(User entity)
        {
            return _repo.Update(entity);
        }
    }
}

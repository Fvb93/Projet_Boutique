using Microsoft.EntityFrameworkCore;
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
    public class UserRepository : IUserRepository
    {
        private readonly BoutiqueContext _context;
        public UserRepository(BoutiqueContext context)
        {
            _context = context;
        }
        public bool Create(User entity)
        {
            User user = _context.Users.Add(entity).Entity;
            if (user != null)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User? GetById(int key)
        {
            return _context.Users.FirstOrDefault(p => p.Id == key);
        }
        public User? GetByName(string key)
        {
            return _context.Users.FirstOrDefault(p => p.Name.Contains(key));
        }
        public bool Update(User entity)
        {
            User? user = _context.Users.FirstOrDefault(p => p.Id == entity.Id);
            if (user != null)
            {
                user.Name = entity.Name;
                user.FirstName = entity.FirstName;
                user.BirthDate = entity.BirthDate;
                user.Email = entity.Email;
                user.Password = entity.Password;
                user.Admin = entity.Admin;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

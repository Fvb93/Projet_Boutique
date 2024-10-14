using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<int, User>
    {
        public User? GetByEmail(string key);
    }
}

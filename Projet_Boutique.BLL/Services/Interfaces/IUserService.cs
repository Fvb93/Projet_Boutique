using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Services.Interfaces
{
    public interface IUserService : IService<int, User>
    {
        public User GetByName(string key);
    }
}

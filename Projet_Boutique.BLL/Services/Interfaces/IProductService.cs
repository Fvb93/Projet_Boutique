using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Services.Interfaces
{
    public interface IProductService : IService<int, Product>
    {
        public Product GetByName(string key);
        public bool Create(Product entity, List<int> ints);
    }
}

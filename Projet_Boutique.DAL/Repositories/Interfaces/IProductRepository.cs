using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<int, Product>
    {
        public Product? GetByName(string key);
        public bool Create(Product entity, List<int> ints);
        public bool Update(Product entity, List<int> ints);
    }
}


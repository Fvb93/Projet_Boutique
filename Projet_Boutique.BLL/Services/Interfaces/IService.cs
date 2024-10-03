using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Services.Interfaces
{
    public interface IService<Key, T>
    {
        public List<T> GetAll();
        public T GetById(Key key);
        public bool Create(T entity);
        public bool Update(T entity);
        public void Delete(T entity);
    }
}

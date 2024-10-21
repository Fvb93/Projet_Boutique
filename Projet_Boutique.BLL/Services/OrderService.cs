using Projet_Boutique.BLL.Models.Exceptions;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.DataBase;
using Projet_Boutique.DAL.Entities;
using Projet_Boutique.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }
        public bool Create(Order entity)
        {
            return _repo.Create(entity);
        }
        public void Delete(Order entity)
        {
            Order? order = _repo.GetById(entity.Id);
            if (order is null)
            {
                throw new ProductNotFoundException($"Aucune commmande n'a été trouvé, suppression impossible");
            }
            _repo.Delete(entity);
        }
        public List<Order> GetAll()
        {
            return _repo.GetAll();
        }
        public Order GetById(int key)
        {
            Order? order = _repo.GetById(key);

            if (order is null)
            {
                throw new ProductNotFoundException($"Aucune commande n'a été trouvé avec l'id {key}");
            }

            return order;
        }
        public bool Update(Order entity)
        {
            return _repo.Update(entity);
        }
    }
}

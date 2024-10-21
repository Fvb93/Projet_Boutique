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
    public class OrderRepository : IOrderRepository
    {
        private readonly BoutiqueContext _context;
        public OrderRepository(BoutiqueContext context)
        {
            _context = context;
        }
        public bool Create(Order entity)
        {
            Order order = _context.Orders.Add(entity).Entity;
            if (order != null)
            {
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
            _context.SaveChanges();
        }
        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
        public Order? GetById(int key)
        {
            return _context.Orders.FirstOrDefault(p => p.Id == key);
        }
        public bool Update(Order entity, Dictionary<int,int> ListeProduits)
        {
            Order? order = _context.Orders.Include(c => c.ProductList).ThenInclude(cp => cp.Product).FirstOrDefault(p => p.Id == entity.Id);
            if (order != null)
            {
                order.ProductList.Clear();
                foreach (var item in ListeProduits)
                {
                    if (ListeProduits.Any())
                    {
                        order.ProductList.Add(new OrderProduct { ProductId = item.Key , Quantity = item.Value});
                        _context.SaveChanges();
                    }
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update(Order entity)
        {
            Order? order = _context.Orders.Include(c => c.ProductList).ThenInclude(cp => cp.Product).FirstOrDefault(p => p.Id == entity.Id);
            if (order != null)
            {
                order.ProductList = entity.ProductList;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

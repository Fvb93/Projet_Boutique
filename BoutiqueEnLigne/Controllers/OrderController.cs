using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        private readonly IUserService _serviceUser;
        public OrderController(IOrderService service, IUserService serviceUser)
        {
            _service = service;
            _serviceUser = serviceUser;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProductToCart([FromForm] ProductFormModel ajoutProduit)
        {
            int id = (int)HttpContext.Session.GetInt32("Id");
            User user = _serviceUser.GetById(id);
            var orderUser = user.OrderList.FirstOrDefault(o => !o.IsFinalized);
            if (orderUser == null)
            {
                orderUser = new Order
                {
                    OrderUser = user,
                    TransactionDate = DateTime.Now,
                    IsFinalized = false,
                    ProductList = new List<OrderProduct>()
                };
                user.OrderList.Add(orderUser);
            }
            var orderProductList = orderUser.ProductList.Any();
            
            if (orderProductList == true)
            {
                var orderProduct = orderUser.ProductList.FirstOrDefault(p => p.ProductId == ajoutProduit.Id);
                orderUser.ProductList.Remove(orderProduct);
                orderProduct.Quantity++;
                orderUser.ProductList.Add(orderProduct);
                _service.Update(orderUser);
            }
            else
            {
                var orderProduct = new OrderProduct
                {
                    ProductId = ajoutProduit.Id,
                    Product = ajoutProduit.FromFormtoProduct(),
                    Quantity = 1,
                    AmountHTVA = ajoutProduit.Price,
                    AmountTVAC = ajoutProduit.Price + (ajoutProduit.TVA / 100),
                };
                orderUser.ProductList.Add(orderProduct);
                _service.Create(orderUser);
            }
            return RedirectToAction("Index", "Product");
        }
        public void RemoveProductFromCart(User user, Product product)
        {
            var order = user.OrderList.FirstOrDefault(o => !o.IsFinalized);
            if (order != null)
            {
                var orderProduct = order.ProductList.FirstOrDefault(op => op.ProductId == product.Id);
                if (orderProduct != null)
                {
                    order.ProductList.Remove(orderProduct);
                }
            }
        }
        public void Checkout(User user)
        {
            var order = user.OrderList.FirstOrDefault(o => !o.IsFinalized);
            if (order == null || !order.ProductList.Any())
            {
                throw new InvalidOperationException("Le panier est vide.");
            }

            // Calculer le montant total de la commande
            order.Amount = order.ProductList.Sum(op => op.AmountTVAC);

            // Marquer l'ordre comme finalisé
            order.IsFinalized = true;

            // Optionnel : Mettre à jour la date de transaction
            order.TransactionDate = DateTime.Now;
        }
    }
}

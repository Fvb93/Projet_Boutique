using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProductToCart(User user, Product product, int quantity)
        {
            var order = user.OrderList.FirstOrDefault(o => !o.IsFinalized);
            if (order == null)
            {    
                order = new Order
                {
                    OrderUser = user,
                    TransactionDate = DateTime.Now,
                    IsFinalized = false,
                    ProductList = new List<OrderProduct>()
                };
                user.OrderList.Add(order);
            }
            var orderProduct = order.ProductList.FirstOrDefault(op => op.ProductId == product.Id);
            
            if (orderProduct != null)
            {
                orderProduct.Quantity++;
                Dictionary<int, int> ProduitQuantité = new Dictionary<int, int>()
                    {
                        { product.Id ,  orderProduct.Quantity }
                    };

                _service.Update(order, ProduitQuantité);
            }
            else
            {
                order.ProductList.Add(new OrderProduct
                {
                    ProductId = product.Id,
                    Product = product,
                    Quantity = quantity,
                    AmountTVAC = (float)((product.Price + (product.TVA / 100)) * quantity),
                    AmountHTVA = (float)(product.Price * quantity)
                });
                _service.Create(order);
            }
            return RedirectToAction("Index", "Product");
        }
        public void RemoveProductFromCart(User user, int productId)
        {
            var order = user.OrderList.FirstOrDefault(o => !o.IsFinalized);
            if (order != null)
            {
                var orderProduct = order.ProductList.FirstOrDefault(op => op.ProductId == productId);
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

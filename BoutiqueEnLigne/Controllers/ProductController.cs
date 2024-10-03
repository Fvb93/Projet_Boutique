using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController (IProductService service)
            {
                _service = service;
            }
        public IActionResult Index()
        {
            IEnumerable<ProductViewModel> productsList = _service.GetAll()
                                                        .Select(p => p.toViewModel())
                                                        .ToList();
            return View(productsList);
        }
        public IActionResult Detail([FromRoute]int id)
        {
            ProductViewModel detailProduct = _service.GetById(id).toViewModel();
            if (detailProduct is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(detailProduct);
        }
    }
}


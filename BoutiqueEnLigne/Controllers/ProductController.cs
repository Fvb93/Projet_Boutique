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
        public IActionResult Delete([FromRoute] int id)
        {
            Product detailProduct = _service.GetById(id);
            if (detailProduct is null)
            {
                return RedirectToAction(nameof(Index));
            }
            _service.Delete(detailProduct);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm] ProductFormModel ajoutProduit)
        {
            if (!ModelState.IsValid)
            {
                return View(ajoutProduit);
            }

            _service.Create(ajoutProduit.fromFormtoProduct());

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update([FromRoute] int id)
        {
            Product majProduct = _service.GetById(id);
            if (majProduct   is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(majProduct.toFormModel());
        }
        [HttpPost]
        public IActionResult Update(int id,[FromForm] ProductFormModel modifierProduit)
        {
            if (!ModelState.IsValid)
            {
                return View(modifierProduit);
            }
           
            modifierProduit.Id = id;
            _service.Update(modifierProduit.fromFormtoProduct());
            return RedirectToAction(nameof(Index));
        }
    }
}

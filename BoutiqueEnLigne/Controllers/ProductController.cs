using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;
using System.Diagnostics.Metrics;

namespace BoutiqueEnLigne.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly ICategoryService _serviceCategorie;
        public ProductController (IProductService service, ICategoryService serviceCat)
            {
                _service = service;
                _serviceCategorie = serviceCat;
            }
        public IActionResult Index()
        {
            IEnumerable<ProductViewModel> productsList = _service.GetAll()
                                                        .Select(p => p.ToViewModel())
                                                        .ToList();
            return View(productsList);
        }
        public IActionResult Detail([FromRoute] int id)
        {
            ProductViewModel detailProduct = _service.GetById(id).ToViewModel();
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
            var categoriesList = _serviceCategorie.GetAll();
            var model = new ProductFormModel
            {
                Categories = categoriesList.Select(c => new CategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    IsSelected = false
                }).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add([FromForm] ProductFormModel ajoutProduit)
        {
            if (!ModelState.IsValid)
            {
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    foreach (var error in state.Errors) // Permet de voir les messages d'erreurs
                    {
                        Console.WriteLine($"Erreur dans le champ {key}: {error.ErrorMessage}");
                    }
                }
            return View(ajoutProduit);
            }

            var selectedCategories = ajoutProduit.Categories
                                        .Where(c => c.IsSelected)
                                        .Select(c => c.Id)
                                        .ToList();

            // Vérifier si des catégories ont été sélectionnées
            if (selectedCategories.Any())
            {
                Console.WriteLine("Catégories sélectionnées : " + string.Join(", ", selectedCategories));
            }
            else
            {
                Console.WriteLine("Aucune catégorie sélectionnée");
            }

            _service.Create(ajoutProduit.FromFormtoProduct(), selectedCategories);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update([FromRoute] int id)
        {
            Product majProduct = _service.GetById(id);
            if (majProduct   is null)
            {
                return RedirectToAction(nameof(Index));
            }

            var categoriesList = _serviceCategorie.GetAll();
            var model = new ProductFormModel
            {
                Id = majProduct.Id,
                Name = majProduct.Name,
                Description = majProduct.Description,
                Price = majProduct.Price,
                Stock = majProduct.Stock,
                TVA = majProduct.TVA,
                Categories = categoriesList.Select(c => new CategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    IsSelected = false
                }).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update([FromForm] ProductFormModel modifierProduit)
        {
            if (!ModelState.IsValid)
            {
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    foreach (var error in state.Errors) // Permet de voir les messages d'erreurs
                    {
                        Console.WriteLine($"Erreur dans le champ {key}: {error.ErrorMessage}");
                    }
                }
                return View(modifierProduit);
            }
            var selectedCategories = modifierProduit.Categories
                                        .Where(c => c.IsSelected)
                                        .Select(c => c.Id)
                                        .ToList();

            // Vérifier si des catégories ont été sélectionnées
            if (selectedCategories.Any())
            {
                Console.WriteLine("Catégories sélectionnées : " + string.Join(", ", selectedCategories));
            }
            else
            {
                Console.WriteLine("Aucune catégorie sélectionnée");
            }

            _service.Update(modifierProduit.FromFormtoProduct(), selectedCategories);
            return RedirectToAction(nameof(Index));
        }
    }
}

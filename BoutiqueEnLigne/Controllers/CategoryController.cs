using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;

namespace BoutiqueEnLigne.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> categorieListe = _service.GetAll()
                                                        .Select(p => p.ToViewModel())
                                                        .ToList();
            return View(categorieListe);
        }

        public IActionResult Detail([FromRoute] int id)
        {
            CategoryViewModel detailCategorie = _service.GetById(id).ToViewModel();
            if (detailCategorie is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(detailCategorie);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm] CategoryFormModel ajoutCategorie)
        {
            if (!ModelState.IsValid)
            {
                return View(ajoutCategorie);
            }

            _service.Create(ajoutCategorie.FromFormtoCategory());

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete([FromRoute] int id)
        {
            Category detailCategorie = _service.GetById(id);
            if (detailCategorie is null)
            {
                return RedirectToAction(nameof(Index));
            }
            _service.Delete(detailCategorie);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update([FromRoute] int id)
        {
            Category majCategory = _service.GetById(id);
            if (majCategory is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(majCategory.ToFormModel());
        }
        [HttpPost]
        public IActionResult Update(int id, [FromForm] CategoryFormModel modifierCategory)
        {
            if (!ModelState.IsValid)
            {
                return View(modifierCategory);
            }

            modifierCategory.Id = id;
            _service.Update(modifierCategory.FromFormtoCategory());
            return RedirectToAction(nameof(Index));
        }
    }
}

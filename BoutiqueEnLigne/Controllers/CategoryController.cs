﻿using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;

namespace BoutiqueEnLigne.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController (ICategoryService service)
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
    }
}

using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using System.Diagnostics;

namespace BoutiqueEnLigne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _service;


        public HomeController(ILogger<HomeController> logger, IProductService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Article()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;

namespace BoutiqueEnLigne.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            IEnumerable<UserViewModel> usersList = _service.GetAll()
                                            .Select(p => p.ToViewModel())
                                            .ToList();
            return View(usersList);
        }
    }
}

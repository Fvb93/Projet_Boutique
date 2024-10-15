using BoutiqueEnLigne.Mapper;
using BoutiqueEnLigne.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Projet_Boutique.BLL.Services.Interfaces;
using Projet_Boutique.DAL.Entities;
using System.Security.Claims;

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
        public IActionResult Detail([FromRoute] int id)
        {
            UserViewModel detailUser = _service.GetById(id).ToViewModel();
            if (detailUser is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(detailUser);
        }
        public IActionResult Delete([FromRoute] int id)
        {
            User detailUser = _service.GetById(id);
            if (detailUser is null)
            {
                return RedirectToAction(nameof(Index));
            }
            _service.Delete(detailUser);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm] UserFormModel ajoutUser)
        {
            if (!ModelState.IsValid)
            {
                return View(ajoutUser);
            }

            _service.Create(ajoutUser.FromFormtoUser());
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update([FromRoute] int id)
        {
            User majUser = _service.GetById(id);
            if (majUser is null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(majUser.ToFormModel());
        }
        [HttpPost]
        public IActionResult Update([FromForm] UserFormModel modifierUser)
        {
            if (!ModelState.IsValid)
            {
                return View(modifierUser);
            }
            _service.Update(modifierUser.FromFormtoUser());
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(UserFormModel user)
        {
            User userBD = _service.GetByEmail(user.Email);
                if (user.Email == userBD.Email && user.Password == userBD.Password)
                {
                // Appel de la méthode SignInUser pour créer les claims (incluant l'admin)
                await SignInUser(userBD);

                HttpContext.Session.SetString("Email", userBD.Email);
                HttpContext.Session.SetString("Prenom", userBD.FirstName);
                HttpContext.Session.SetInt32("Id", userBD.Id);

                return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Nom d'utilisateur ou mot de passe incorrect voir inexistant.");
                    return View(user);
            }
        }
        private async Task SignInUser(User user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email),
            new Claim("Admin", user.Admin.ToString()) // Ajoute un claim pour la propriété Admin
        };

            var identity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(claimsPrincipal);
        }
        public async Task<IActionResult> LogoutAsync()
        {
            HttpContext.Session.Clear();

            // Déconnecte l'utilisateur en supprimant les cookies d'authentification
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index","Home");
        }
    }
}

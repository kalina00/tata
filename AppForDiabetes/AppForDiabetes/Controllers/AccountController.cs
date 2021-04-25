using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using AppForDiabetes.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace AuthApp.Controllers
{
    public class AccountController : Controller
    {
        private DiabetesContext db;

        public AccountController(DiabetesContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Registr()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Registr(Humans humans)
        {
                if (ModelState.IsValid)
            {
                Humans human = await db.humans.FirstOrDefaultAsync(x => x.Login == humans.Login);
                if (human == null)
                {
                    db.humans.Add(humans);// сохраняем в бд все изменения
                    db.SaveChanges();

                    await Authenticate(humans.Login); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }

            return View(humans);
        }
           
            
       
        [HttpGet]
        public IActionResult Login ()
        {
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login (Humans human)
        {
            if (ModelState.IsValid)
            {
                Humans human1 = await db.humans.FirstOrDefaultAsync(u => u.Login == human.Login && u.Password == human.Password);
                if (human1 != null)
                {
                    await Authenticate(human.Login); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(human);
        }


        private async Task Authenticate(string humanNames)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType,humanNames)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
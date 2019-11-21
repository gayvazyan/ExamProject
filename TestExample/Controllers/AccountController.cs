using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestExample.Models;
using TestExample.MyModels;
using TestExample.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestExample.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CitizenUser> _userManager;
        private readonly SignInManager<CitizenUser> _signInManager;
        private readonly ExamDbContect _examDBContect;


        public AccountController(UserManager<CitizenUser> userManager,
            SignInManager<CitizenUser> signInManager,
            ExamDbContect examDBContect)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _examDBContect = examDBContect;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Copy data from RegisterViewModel to IdentityUser
                var user = new CitizenUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName =model.FirstName,
                    LastName = model.LastName,
                    SecondName = model.SecondName,
                    Passport = model.Passport,
                    PhoneNumber =model.PhoneNumber

                };

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    CitizenReport citizenReport = new CitizenReport()
                    {

                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        SecondName = user.SecondName,
                        PhoneNumber = user.PhoneNumber,
                        Email = user.Email,
                        TestDataTime = DateTime.MinValue,
                        Result_Test1 = 0,
                        NumberTicket = 0,
                        Passport = user.Passport,
                        Notification = "Ծանուցված չէ"

                    };

                    _examDBContect.DbCitizenReport.Update(citizenReport);
                    _examDBContect.SaveChanges();

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
    }
}

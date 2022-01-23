using eugeneCollections.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        public AccountController(SignInManager<User> signInManager) => this.signInManager = signInManager;
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

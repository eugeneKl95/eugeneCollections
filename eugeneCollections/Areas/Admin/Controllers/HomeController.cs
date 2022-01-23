using eugeneCollections.Domain;
using eugeneCollections.Domain.Entities;
using eugeneCollections.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly AppDbContext appDbContext;

        public HomeController(DataManager dataManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager,AppDbContext context)
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
            appDbContext = context;
        }

        public IActionResult Index()
        {
            return View(dataManager);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var userRoles = await userManager.GetRolesAsync(user);
            var allRoles = roleManager.Roles.ToList();
            EditUserViewModel model = new EditUserViewModel 
            { Id = user.Id, Email = user.Email, UserName = user.UserName,
                UserRoles=userRoles,AllRoles=allRoles, State=user.State };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserViewModel model,string userRoles, string newRole,string status)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                    user.State = status;

                    var result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var res1 =await userManager.RemoveFromRoleAsync(user, userRoles);
                        var res = await userManager.AddToRoleAsync(user, newRole);
                        appDbContext.Users.Update(user);
                        int t=await appDbContext.SaveChangesAsync();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }
    }
}

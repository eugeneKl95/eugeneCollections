using eugeneCollections.Domain;
using eugeneCollections.Domain.Entities;
using eugeneCollections.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        private IWebHostEnvironment hostEnv;
        public CollectionsController(DataManager dataManager, AppDbContext context, 
            IWebHostEnvironment env) 
        {
            this.dataManager = dataManager;
            this.context = context;
            hostEnv = env;
        } 
        [HttpGet]
        public IActionResult Index()
        {
            return View("Collections",dataManager.Themes.GetThemes());
        }
        [HttpPost]
        public IActionResult Index(Theme theme)
        {
            return RedirectToAction("ViewCollection", theme);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddCollection()
        {
            ViewBag.Themes = dataManager.Themes.GetThemes();
            return View(new AddCollectionViewModel() { UserName=User.Identity.Name});
        }
        [HttpPost]
        [Authorize]
        public  async Task<IActionResult> AddCollection(AddCollectionViewModel addCollection,IFormFile file)
        {
            //if (HttpContext.Request.Form.Files.Count != 0)
            //{
            //    if (HttpContext.Request.Form.Files[0] != null)
            //    {
            //        var fileN = HttpContext.Request.Form.Files[0];
            //        using (FileStream fs = new FileStream("Your Path", FileMode.CreateNew, FileAccess.Write, FileShare.Write))
            //        {
            //            fileN.CopyTo(fs);
            //        }
            //    }
            //}

            var fileDic = "Files";
            string filePath = Path.Combine(hostEnv.WebRootPath, fileDic);
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            var fileName = file.FileName;
            filePath = Path.Combine(filePath, fileName);
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                file.CopyTo(fs);
            }
            Collection collection = new Collection();
            collection.Name = addCollection.NameCollection;
            collection.Description = addCollection.DescriptionCollection;
            collection.ThemeId = addCollection.ThemeId;
            collection.PathImg = addCollection.PathImg;
            collection.UserId = dataManager.Users.GetUserByName(addCollection.UserName).Id;
            context.Collections.Add(collection);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult ViewCollection(Theme theme)
        {
            return View(dataManager.Collections.GetCollectionsByThemeId(theme.Id));
        }
        [HttpGet]
        public IActionResult Edit(int id,string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(dataManager.Collections.GetCollectionById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Collection collection,string returnUrl)
        {
            await dataManager.Collections.UpdateCollection(collection);
            return Redirect(returnUrl ?? "/");
        }
    }
}

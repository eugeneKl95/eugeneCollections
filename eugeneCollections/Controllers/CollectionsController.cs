using eugeneCollections.Domain;
using eugeneCollections.Domain.Entities;
using eugeneCollections.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Controllers
{
    public class CollectionsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        public CollectionsController(DataManager dataManager, AppDbContext context) 
        {
            this.dataManager = dataManager;
            this.context = context;
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
        public IActionResult AddCollection(Theme theme)
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult AddCollection(AddCollectionViewModel addCollection)
        {
            Collection collection = new Collection();
            collection.Name = addCollection.NameCollection;
            collection.Description = addCollection.DescriptionCollection;
            collection.ThemeId = addCollection.ThemeId;
            collection.PathImg = addCollection.PathImg;
            context.Collections.Add(collection);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ViewCollection(Theme theme)
        {
            return View(dataManager.Collections.GetCollectionsByThemeId(theme.Id));
        }
    }
}

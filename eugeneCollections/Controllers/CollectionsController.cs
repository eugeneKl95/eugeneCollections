using eugeneCollections.Domain;
using eugeneCollections.Domain.Entities;
using eugeneCollections.Models;
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
            
        public IActionResult Index()
        {
            return View("Collections",dataManager.Themes.GetThemes());
        }
        [HttpGet]
        public IActionResult AddCollection()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCollection(AddCollectionViewModel addCollection)
        {
            Collection collection = new Collection();
            collection.Name = addCollection.NameCollection;
            collection.Description = addCollection.DescriptionCollection;
            collection.ThemeId = addCollection.ThemeId;
            collection.PathImg = addCollection.PathImg;
            context.Collections.Add(collection);
            context.SaveChanges();
            return Redirect("/Collections/Index");
        }
    }
}

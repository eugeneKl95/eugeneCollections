using eugeneCollections.Domain;
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
        public CollectionsController(DataManager dataManager) => this.dataManager = dataManager;
            
        public IActionResult Index()
        {
            return View("Collections",dataManager.Themes.GetThemes());
        }
    }
}

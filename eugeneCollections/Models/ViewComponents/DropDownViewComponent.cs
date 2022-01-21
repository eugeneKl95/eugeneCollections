using eugeneCollections.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Models.ViewComponents
{
    public class DropDownViewComponent:ViewComponent
    {
        private readonly DataManager dataManager;

        public DropDownViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult)View("DropDown", dataManager.Themes.GetThemes()));
        }
    }
}

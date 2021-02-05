using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class HomeController : RenderMvcController
    {
        private GetItemTypesDBHandler getItemTypesDbHandler = new GetItemTypesDBHandler();

        public ActionResult Index(ContentModel model)
        {
            var homePageModel = new HomeContentModel(model.Content);

            var getItemTypes = getItemTypesDbHandler.GetItemTypes();

            var homeViewModel = new HomeViewModel()//passing the search values from query strings to the search view model
            {
                ItemTypesData = getItemTypes
            };

            var homeModel = new Home(model.Content);


            homePageModel.HomeViewModel = homeViewModel;

            homePageModel.Home = homeModel;

            return CurrentTemplate(homePageModel);
        }
    }
}
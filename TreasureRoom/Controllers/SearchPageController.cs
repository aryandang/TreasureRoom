using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class SearchPageController : RenderMvcController
    {
        public ActionResult Index(ContentModel model, string keyword, string postCode, string itemType)
        {
            var homePageModel = new SearchContentModel(model.Content);

            homePageModel.Keyword = keyword;
            homePageModel.Postcode = postCode;
            homePageModel.ItemType = itemType;

            return CurrentTemplate(homePageModel);
        }
    }
}
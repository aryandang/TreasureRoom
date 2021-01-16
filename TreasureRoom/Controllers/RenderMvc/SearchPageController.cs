using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using TreasureRoom.Models;
using TreasureRoom.Models.ViewModel;
using TreasureRoom.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class SearchPageController : RenderMvcController//get the search values from the query string and pass it to the view model
    {

        public ActionResult Index(ContentModel model, string keyword, string postCode, string itemType)
        {
            var searchPageModel = new SearchContentModel(model.Content);
            TreasureRoomEntities db = new TreasureRoomEntities();

            var searchViewModel = new SearchViewModel()//passing the search values from query strings to the search view model
            {
                Keyword = keyword,
                Postcode = postCode,
                ItemType = itemType
            };

            searchPageModel.SearchViewModel = searchViewModel;

            if (!keyword.IsNullOrWhiteSpace() && !postCode.IsNullOrWhiteSpace() && !itemType.IsNullOrWhiteSpace())
            {
                return CurrentTemplate(db.dbo_LostItems.Where(m => (m.Description.Contains(keyword)) && (m.Postcode.Contains(postCode)) && (m.ItemType.Contains(itemType))).ToList());
            }

            return CurrentTemplate(searchPageModel);
        }
    }
}
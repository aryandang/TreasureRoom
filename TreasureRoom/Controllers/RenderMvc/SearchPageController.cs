﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class SearchPageController : RenderMvcController//get the search values from the query string and pass it to the view model
    {
        public ActionResult Index(ContentModel model, string keyword, string postCode, string itemType)
        {
            var searchPageModel = new SearchContentModel(model.Content);

            var searchViewModel = new SearchViewModel()//passing the search values to the search view model
            {
                Keyword = keyword,
                Postcode = postCode,
                ItemType = itemType
            };
            searchPageModel.SearchViewModel = searchViewModel;

            return CurrentTemplate(searchPageModel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class SearchSurfaceController : SurfaceController
    {
        public ActionResult SubmitForm(SearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var queryString = new NameValueCollection();

            if (!string.IsNullOrWhiteSpace(model.Keyword))
            {
                queryString.Add("Keyword", model.Keyword);
            } 
            if (!string.IsNullOrWhiteSpace(model.Postcode))
            {
                queryString.Add("Postcode", model.Postcode);
            } 
            if (!string.IsNullOrWhiteSpace(model.ItemType))
            {
                queryString.Add("ItemType", model.ItemType);
            }

            return RedirectToCurrentUmbracoPage(queryString);
        }
    }
}
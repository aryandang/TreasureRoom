using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class LostItemDetailsSurfaceController : SurfaceController
    {
        public ActionResult LoadForm(LostItemDetailsViewModel model, string id)
        {
            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                queryString.Add("id", model.ID);
            }

            return RedirectToUmbracoPage(1236, queryString);
        }
    }
}
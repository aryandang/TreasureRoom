using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace TreasureRoom.Controllers.Surface
{
    public class PostSurfaceController : SurfaceController
    {
        public ActionResult SubmitForm(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ItemType.Contains("Electronic"))
                {
                    return Redirect("/lost-electronic/");
                }
            }
            return CurrentUmbracoPage();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class PostSurfaceController : SurfaceController
    {
        private PostLostItemsDBHandler postLostItemsDbHandler = new PostLostItemsDBHandler();
        public const string partialViewFolder = "~Views/Partials/";
        public ActionResult RenderForm()
        {
            return PartialView(partialViewFolder + "PostForm.cshtml");
        }

        public ActionResult SubmitForm(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                postLostItemsDbHandler.PostLostItemsData(model);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
    }
}
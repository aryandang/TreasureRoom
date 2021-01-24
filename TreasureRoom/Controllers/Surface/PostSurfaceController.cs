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
                model.ID = GuidGenerator();
                postLostItemsDbHandler.PostLostItemsData(model);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

        public string GuidGenerator()
        {
            var obj = Guid.NewGuid();
            return obj.ToString();
        }
    }
}
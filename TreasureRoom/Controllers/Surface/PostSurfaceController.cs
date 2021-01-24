using System;
using System.Collections.Generic;
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
        private PostLostItemsDBHandler postLostItemsDbHandler = new PostLostItemsDBHandler();

        public ActionResult SubmitForm(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ID = GuidGenerator();
                postLostItemsDbHandler.PostLostItemsData(model);
                return Redirect("/success");
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
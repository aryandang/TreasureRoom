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
        private PostLostItemsDBHandler postLostItemsDbHandler = new PostLostItemsDBHandler();
        public ActionResult SubmitForm(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                SaveImage(model);
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

        [HttpPost]
        public void SaveImage(PostViewModel model)
        {
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("ddMMyyyy") + extension;
            model.ImagePath = "~/Items-Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Items-Images/"), fileName);
            model.ImageFile.SaveAs(fileName);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using TreasureRoom.Services;
using Umbraco.Web.Models.ContentEditing;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class EditOrDeleteItemSurfaceController : SurfaceController
    {
        private UpdateLostItemsDBHandler updateLostItemsDbHandler = new UpdateLostItemsDBHandler();

        public ActionResult EditForm(EditOrDeleteItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                SaveImage(model);
                updateLostItemsDbHandler.UpdateLostItemsData(model);
                return RedirectToUmbracoPage(1247);
            }

            return CurrentUmbracoPage();
        }

        [HttpPost]
        public void SaveImage(EditOrDeleteItemViewModel model)
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
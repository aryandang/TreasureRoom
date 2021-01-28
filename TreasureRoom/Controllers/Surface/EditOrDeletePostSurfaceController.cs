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
    public class EditOrDeletePostSurfaceController : SurfaceController
    {
        private GetLostItemsByEditIdDBHandler getLostItemsByEditIdDbHandler = new GetLostItemsByEditIdDBHandler();

        public ActionResult SubmitForm(EditOrDeletePostViewModel model)
        {
            if (ModelState.IsValid)
            {
                var getItemsByEditId = getLostItemsByEditIdDbHandler.GetLostItemsById(model.EditID);
                model.LostItemsData = getItemsByEditId;
                foreach (var value in model.LostItemsData)
                {
                    if (model.EditID.Equals(value.EditID))
                    {
                        return RedirectToUmbracoPage(1246, model.EditID);
                    }
                    return CurrentUmbracoPage();
                }
            }
            return CurrentUmbracoPage();
        }
    }
}
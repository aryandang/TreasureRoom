using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.EditID))
            {
                queryString.Add("editId", model.EditID);
            }
            if (ModelState.IsValid)
            {
                var getItemsByEditId = getLostItemsByEditIdDbHandler.GetLostItemsById(model.EditID);
                model.LostItemsData = getItemsByEditId;

                if (model.LostItemsData.Count != 0)
                {
                    foreach (var value in model.LostItemsData)
                    {

                        if (model.EditID.Equals(value.EditID))
                        {
                            return RedirectToUmbracoPage(1246, queryString);
                        }
                        return RedirectToUmbracoPage(1254);
                    }
                }
                else
                {
                    return RedirectToUmbracoPage(1254);
                }
                

            }
            return CurrentUmbracoPage();
        }
    }
}
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
    public class DeleteItemSurfaceController : SurfaceController
    {
        private DeleteLostItemsDbHandler deleteLostItemsDbHandler = new DeleteLostItemsDbHandler();

        public ActionResult LoadForm(DeleteItemViewModel model)
        {
            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.EditID))
            {
                queryString.Add("editId", model.EditID);
            }
            return RedirectToUmbracoPage(1251, queryString);
        }

        public ActionResult DeleteForm(DeleteItemViewModel model)
        {
            deleteLostItemsDbHandler.DeleteLostItemsData(model.EditID);
            return RedirectToUmbracoPage(1248);
        }
    }
}
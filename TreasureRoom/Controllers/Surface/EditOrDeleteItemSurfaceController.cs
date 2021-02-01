using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using TreasureRoom.Services;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class EditOrDeleteItemSurfaceController : SurfaceController
    {
        private UpdateLostItemsDBHandler updateLostItemsDbHandler = new UpdateLostItemsDBHandler();
        private DeleteLostItemsDbHandler deleteLostItemsDbHandler = new DeleteLostItemsDbHandler();
        private GetLostItemsByEditIdDBHandler getLostItemsByEditIdDbHandler = new GetLostItemsByEditIdDBHandler();
        private EditLostItemService editLostItemService = new EditLostItemService();
        
        public ActionResult EditForm(EditOrDeleteItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                updateLostItemsDbHandler.UpdateLostItemsData(model);
            }
            return CurrentUmbracoPage();
        }
    }
}
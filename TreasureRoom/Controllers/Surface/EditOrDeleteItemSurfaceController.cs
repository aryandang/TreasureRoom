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
    public class EditOrDeleteItemSurfaceController : SurfaceController
    {
        private GetLostItemsByEditIdDBHandler getLostItemsByEditIdDbHandler = new GetLostItemsByEditIdDBHandler();

        public ActionResult SubmitForm(EditOrDeleteItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                
            }
            return CurrentUmbracoPage();
        }
    }
}
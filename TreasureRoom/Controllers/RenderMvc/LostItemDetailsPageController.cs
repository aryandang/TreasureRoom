﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class LostItemDetailsPageController: RenderMvcController
    {
        private GetLostItemsByIdDBHandler geteLostItemsByIdDbHandler = new GetLostItemsByIdDBHandler();

        public ActionResult Index(ContentModel model, string id)
        {
            var lostItemDetailsPageModel = new LostItemDetailsContentModel(model.Content);

            var getLostItemsDataById = geteLostItemsByIdDbHandler.GetLostItemsById(id);

            var lostItemDetailsViewModel = new LostItemDetailsViewModel()
            {
                LostItemsData = getLostItemsDataById
            };

            lostItemDetailsPageModel.LostItemDetailsViewModel = lostItemDetailsViewModel;

            return CurrentTemplate(lostItemDetailsPageModel);
        }
    }
}
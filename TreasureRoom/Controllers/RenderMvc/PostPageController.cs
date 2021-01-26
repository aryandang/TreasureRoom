using System;
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
    public class PostPageController : RenderMvcController
    {
        private GetItemTypesDBHandler getItemTypesDbHandler = new GetItemTypesDBHandler();
        public ActionResult Index(ContentModel model)
        {
            var postPageModel = new PostContentModel(model.Content);

            var getItemTypesData = getItemTypesDbHandler.GetItemTypes();

            var postViewModel = new PostViewModel()
            {
                ItemTypesData = getItemTypesData
            };

            postPageModel.PostViewModel = postViewModel;

            return CurrentTemplate(postPageModel);
        }
    }
}
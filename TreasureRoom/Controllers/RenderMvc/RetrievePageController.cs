using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class RetrievePageController : RenderMvcController
    {
        private GetLostItemsByIdDBHandler getLostItemsByIdDbHandler = new GetLostItemsByIdDBHandler();
        public ActionResult Index(ContentModel model, string id)
        {
            var retrieveItemPageModel = new RetrieveItemContentModel(model.Content);

            var getLostItemsDataById = getLostItemsByIdDbHandler.GetLostItemsById(id);

             var retrieveViewModel = new RetrieveViewModel()
            {
                LostItemsData = getLostItemsDataById
            };

             retrieveItemPageModel.RetrieveViewModel = retrieveViewModel;

            return CurrentTemplate(retrieveItemPageModel);
        }
    }
}
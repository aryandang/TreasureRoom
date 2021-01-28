using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class EditOrDeleteItemPageController : RenderMvcController
    {
        private GetLostItemsByEditIdDBHandler getLostItemsByEditIdDbHandler = new GetLostItemsByEditIdDBHandler();
        public ActionResult Index(ContentModel model, string editId)
        {
            var editOrDeleteItemPageModel = new EditOrDeleteItemContentModel(model.Content);

            var getItemData = getLostItemsByEditIdDbHandler.GetLostItemsById(editId);

            var editOrDeleteItemViewModel = new EditOrDeleteItemViewModel()
            {
                LostItemsData = getItemData
            };

            editOrDeleteItemPageModel.EditOrDeleteItemViewModel = editOrDeleteItemViewModel;

            return CurrentTemplate(editOrDeleteItemPageModel);
        }
    }
}
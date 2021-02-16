using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class DeleteItemPageController : RenderMvcController
    {
        public ActionResult Index(ContentModel model, string editId)
        {
            var deleteItemPageModel = new DeleteItemContentModel(model.Content);

            var deleteItemViewModel = new DeleteItemViewModel();

            deleteItemPageModel.DeleteItemViewModel = deleteItemViewModel;

            return CurrentTemplate(deleteItemPageModel);
        }
    }
}
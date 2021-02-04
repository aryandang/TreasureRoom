using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.RenderMvc
{
    public class EditOrDeletePostPageController : RenderMvcController
    {

        public ActionResult Index(ContentModel model, string editId)
        {
            var editOrDeletePostPageModel = new EditOrDeletePostContentModel(model.Content);

            var editOrDeletePostViewModel = new EditOrDeletePostViewModel();

            editOrDeletePostPageModel.EditOrDeletePostViewModel = editOrDeletePostViewModel;

            return CurrentTemplate(editOrDeletePostPageModel);
        }
    }
}
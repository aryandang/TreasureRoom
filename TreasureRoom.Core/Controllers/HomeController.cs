using System.Web.Mvc;
using TreasureRoom.ViewModels;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class HomeController : RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            var search = new SearchViewModel(model.Content, model.CurrentCulture);
            //var dropDown = new Search(model.Content);
            return View("Search", SearchViewModel);
        }
    }
}
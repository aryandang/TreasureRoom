using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class HomeController : RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            //var dropDown = new Search(model.Content);
            return CurrentTemplate(model);
        }
    }
}
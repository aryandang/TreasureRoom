using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class HomeController : RenderMvcController
    {
        public ActionResult Index(ContentModel model, string query, string page)
        {
            return CurrentTemplate(model);
        }
    }
}
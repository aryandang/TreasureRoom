using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Core.Controllers
{
    class HomeController : RenderMvcController
    {
        public ActionResult Index(ContentModel model, string query)
        {
            return CurrentTemplate(model);
        }
    }
}

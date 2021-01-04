using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using TreasureRoom.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class HomeController : Controller
    {
        TreasureRoomEntities db = new TreasureRoomEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DropDownSearch()
        {
            ItemTypes model = new ItemTypes();
            model.GetItemTypes = db.Get_ItemTypes();
            return View(model);
        }
    }
}
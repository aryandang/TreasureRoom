using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models;

namespace TreasureRoom.Controllers
{
    public class HomeController : Controller
    {
        TreasureRoomEntities1 db = new TreasureRoomEntities1();
        public ActionResult Index()
        {
            ItemTypes model = new ItemTypes();
            //model.ItemType = db.get_ItemTypes().FirstOrDefault();
            return View(model);
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
    }
}
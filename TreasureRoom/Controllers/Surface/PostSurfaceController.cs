﻿using System.Web.Mvc;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class PostSurfaceController : SurfaceController
    {
        public ActionResult SubmitForm(PostViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ItemType.Contains("Electronic"))
                {
                    return Redirect("/lost-electronic/");
                }
                if (model.ItemType.Contains("Keys"))
                {
                    return Redirect("/lost-keys/");
                }
                if (model.ItemType.Contains("Fashion Accessory"))
                {
                    return Redirect("/lost-fashion-accessory/");
                }
                if (model.ItemType.Contains("Wallet"))
                {
                    return Redirect("/lost-wallet/");
                }
                if (model.ItemType.Contains("Purse"))
                {
                    return Redirect("/lost-purse/");
                }


            }
            return CurrentUmbracoPage();
        }

    }
}
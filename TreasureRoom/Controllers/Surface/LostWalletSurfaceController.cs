﻿using System;
using System.IO;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class LostWalletSurfaceController : SurfaceController
    {
        private PostLostWalletDBHandler postLostWalletOrPurseDbHandler = new PostLostWalletDBHandler();
        public ActionResult SubmitForm(LostWalletViewModel model)
        {
            if (ModelState.IsValid)
            {
                SaveImage(model);
                model.ID = GuidGenerator();
                model.EditID = GuidGenerator();
                model.ItemType = "Wallet";
                postLostWalletOrPurseDbHandler.PostLostItemsData(model);
                return Redirect("/success");
            }
            return CurrentUmbracoPage();
        }

        public string GuidGenerator()
        {
            var obj = Guid.NewGuid();
            return obj.ToString();
        }

        [HttpPost]
        public void SaveImage(LostWalletViewModel model)
        {
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("ddMMyyyy") + extension;
            model.ImagePath = "~/Items-Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Items-Images/"), fileName);
            model.ImageFile.SaveAs(fileName);
        }
    }
}
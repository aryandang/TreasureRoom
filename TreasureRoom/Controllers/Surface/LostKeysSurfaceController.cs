﻿using System;
using System.IO;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using TreasureRoom.Services;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class LostKeysSurfaceController : SurfaceController
    {
        private PostLostKeysDBHandler postLostKeysDbHandler = new PostLostKeysDBHandler();
        private SendEmailService sendEmailService = new SendEmailService();

        public ActionResult SubmitForm(LostKeysViewModel model)
        {
            if (ModelState.IsValid)
            {
                SaveImage(model);
                model.ID = GuidGenerator();
                model.EditID = GuidGenerator();
                model.ItemType = "Keys";
                postLostKeysDbHandler.PostLostItemsData(model);
                sendEmailService.SendConfirmationEmail(model.EmailAddress, model.FullName, model.ItemType, model.EditID);
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
        public void SaveImage(LostKeysViewModel model)
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
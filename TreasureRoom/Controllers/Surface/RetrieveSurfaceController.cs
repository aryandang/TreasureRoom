using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using TreasureRoom.Services;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers.Surface
{
    public class RetrieveSurfaceController : SurfaceController
    {
        private PostRetrieveItemsUsersDBHandler postRetrieveItemsUsersDbHandler = new PostRetrieveItemsUsersDBHandler();
        private SendEmailService sendEmailService = new SendEmailService();
        private GetLostItemsByIdDBHandler getLostItemsByIdDbHandler = new GetLostItemsByIdDBHandler();

        public ActionResult LoadForm(RetrieveViewModel model)
        {
            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.ID))
            {
                queryString.Add("id", model.ID);
            }

            return RedirectToUmbracoPage(1237, queryString);
        }

        [HttpPost]
        public ActionResult SubmitForm(RetrieveViewModel model)
        {
            if (ModelState.IsValid)
            {
                var data = getLostItemsByIdDbHandler.GetLostItemsById(model.ID);
                foreach (var value in data)
                {
                    sendEmailService.SendEmail(value.EmailAddress, value.FullName, value.ItemType, model.FullName, model.EmailAddress, model.PhoneNumber,
                                                value.Question1, model.Answer1Input, value.Question2, model.Answer2Input,
                                                value.Question3, model.Answer3Input);
                }
                postRetrieveItemsUsersDbHandler.PostRetrieveItemsUsersData(model);
                return Redirect("/retrieve-success-page");
            }

            return CurrentUmbracoPage();
        }
    }
}
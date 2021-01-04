using System.Web.Mvc;
using TreasureRoom.Interfaces;
using TreasureRoom.ViewModels;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class AccountSurfaceController : SurfaceController
    {
        private readonly IDataTypeValueService _dataTypeValueService;

        public AccountSurfaceController(IDataTypeValueService dataTypeValueService)
        {
            _dataTypeValueService = dataTypeValueService;
        }

        [HttpGet]
        public ActionResult RenderEditProfile()
        {
            var model = new EditProfileViewModel();

            model.JobTitleOptions =
                _dataTypeValueService.GetItemsFromValueListDataType("[Dropdown] Item Types", selectedValues: null);

            return PartialView("~/Views/Partials/Search.cshtml", model);
        }
    }
}
using System.Web.Mvc;
using TreasureRoom.Models;
using TreasureRoom.Models.DBHandler;
using TreasureRoom.Models.ViewModel;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace TreasureRoom.Controllers
{
    public class SearchPageController : RenderMvcController//get the search values from the query string and pass it to the view model
    {
        private GetLostItemsDBHandler getLostItemsDbHandler = new GetLostItemsDBHandler();

        public ActionResult Index(ContentModel model, string keyword, string postCode, string itemType)
        {
            var searchPageModel = new SearchContentModel(model.Content);
            TreasureRoomEntities db = new TreasureRoomEntities();
            //var data = db.dbo_LostItems.ToList();
            //ViewBag.LostItemsData = data;


            var getLostItems = getLostItemsDbHandler.GetLostItems(keyword, postCode, itemType);

            var searchViewModel = new SearchViewModel()//passing the search values from query strings to the search view model
            {
                Keyword = keyword,
                Postcode = postCode,
                ItemType = itemType,
                LostItemsData = getLostItems
            };


            searchPageModel.SearchViewModel = searchViewModel;
            
            return CurrentTemplate(searchPageModel);
        }
    }
}
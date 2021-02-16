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
        private GetItemTypesDBHandler getItemTypesDbHandler = new GetItemTypesDBHandler();
        private GetLostItemsByIdDBHandler getLostItemsByIdDbHandler = new GetLostItemsByIdDBHandler();

        public ActionResult Index(ContentModel model, string keyword, string postCode, string itemType)
        {
            var searchPageModel = new SearchContentModel(model.Content);

            var getLostItems = getLostItemsDbHandler.GetLostItems(keyword, postCode, itemType);
            var getItemTypes = getItemTypesDbHandler.GetItemTypes();

            var searchViewModel = new SearchViewModel()//passing the search values from query strings to the search view model
            {
                Keyword = keyword,
                Postcode = postCode,
                ItemType = itemType,
                ItemTypesData = getItemTypes,
                LostItemsData = getLostItems
            };


            searchPageModel.SearchViewModel = searchViewModel;
            
            return CurrentTemplate(searchPageModel);
        }

        [HttpPost]
        public ActionResult GetDetails(ContentModel model, string id)
        {
            var lostItemDetailsPageModel = new LostItemDetailsContentModel(model.Content);

            var getLostItemsDataById = getLostItemsByIdDbHandler.GetLostItemsById(id);

            var lostItemDetailsViewModel = new LostItemDetailsViewModel()
            {
                LostItemsData = getLostItemsDataById
            };

            lostItemDetailsPageModel.LostItemDetailsViewModel = lostItemDetailsViewModel;

            return CurrentTemplate(lostItemDetailsPageModel);
        }
    }
}
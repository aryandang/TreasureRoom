//using Examine;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.Ajax.Utilities;
//using TreasureRoom.Models.DBHandler;
//using TreasureRoom.Models.ViewModel;
//using Umbraco.Core.Models.PublishedContent;

//namespace TreasureRoom.Services
//{
//    public class SearchService : ISearchService
//    {
//        private GetLostItemsDBHandler getLostItemsDbHandler = new GetLostItemsDBHandler();
//        public List<LostItemsViewModel> GetSearchResults(string searchTerm, string postCode, string itemType)
//        {
//            var getLostItems = new List<LostItemsViewModel>();
//            if (searchTerm.IsNullOrWhiteSpace() && postCode.IsNullOrWhiteSpace() && itemType.IsNullOrWhiteSpace())
//            {
//                getLostItems = getLostItemsDbHandler.GetLostItems().Where(m => (m.Description.Contains(searchTerm)) &&
//                    (m.Postcode.Contains(postCode))
//                    & (m.ItemType.Contains(itemType))).ToList();
//            }
//            else
//            {
//                getLostItems = getLostItemsDbHandler.GetLostItems();
//            }
           
//            return getLostItems;
//        }
//    }
//}
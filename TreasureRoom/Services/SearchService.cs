using Examine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace TreasureRoom.Services
{
    public class SearchService : ISearchService
    {
        public IEnumerable<IPublishedContent> GetPageOfContentSearchResults(string searchTerm, string postCode, string itemType, out long totalItemCount, string[] docTypeAliases, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISearchResult> GetPageOfSearchResults(string searchTerm, string postCode, string itemType, out long totalItemCount, string[] docTypeAliases, int pageSize = 10)
        {
            throw new NotImplementedException();
        }
    }
}
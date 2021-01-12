using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examine;
using Umbraco.Core.Models.PublishedContent;

namespace TreasureRoom.Services
{
    public interface ISearchService
    {
        //get search results
        IEnumerable<ISearchResult> GetPageOfSearchResults(string searchTerm,
            string postCode, string itemType, out long totalItemCount, string[] docTypeAliases,
            int pageSize = 10);

        //convert the search results to IPublishedContent
        IEnumerable<IPublishedContent> GetPageOfContentSearchResults(string searchTerm,
            string postCode, string itemType, out long totalItemCount, string[] docTypeAliases,
            int pageSize = 10);

    }
}
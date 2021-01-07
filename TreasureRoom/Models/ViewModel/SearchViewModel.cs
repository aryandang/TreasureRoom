using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace TreasureRoom.Models.ViewModel
{
    public class SearchViewModel
    {
        public string Keyword { get; set; }
        public string Postcode { get; set; }
        public string ItemType { get; set; }
    }
}
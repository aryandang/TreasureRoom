using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class HomeContentModel : ContentModel
    {
        public HomeContentModel(IPublishedContent content) : base(content)
        {

        }

        public string Keyword { get; set; }
        public string ItemType { get; set; }
        public string Postcode { get; set; }
    }
}
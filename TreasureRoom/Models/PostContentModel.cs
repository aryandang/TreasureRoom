using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class PostContentModel : ContentModel
    {
        public PostContentModel(IPublishedContent content) : base(content)
        {

        }

    }
}
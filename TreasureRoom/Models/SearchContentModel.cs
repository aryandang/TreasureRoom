using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class SearchContentModel : ContentModel
    {
        public SearchContentModel(IPublishedContent content) : base(content)
        {

        }

        public SearchViewModel SearchViewModel { get; set; }
    }
}
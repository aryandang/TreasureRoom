using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostFashionAccessoryContentModel : ContentModel
    {
        public LostFashionAccessoryContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostFashionAccessoryViewModel LostFashionAccessoryViewModel { get; set; }

    }
}
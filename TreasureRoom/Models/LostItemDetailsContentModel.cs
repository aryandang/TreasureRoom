using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostItemDetailsContentModel : ContentModel
    {
        public LostItemDetailsContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostItemDetailsViewModel LostItemDetailsViewModel { get; set; }
    }
}
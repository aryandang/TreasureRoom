using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class HomeContentModel : ContentModel
    {
        public HomeContentModel(IPublishedContent content) : base(content)
        {

        }

        public HomeViewModel HomeViewModel { get; set; }
    }
}
using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace TreasureRoom.Models
{
    public class HomeContentModel : ContentModel
    {
        public HomeContentModel(IPublishedContent content) : base(content)
        {

        }

        public HomeViewModel HomeViewModel { get; set; }

        public Home Home { get; set; }
    }
}
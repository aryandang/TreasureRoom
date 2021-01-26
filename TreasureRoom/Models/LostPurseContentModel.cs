using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostPurseContentModel : ContentModel
    {
        public LostPurseContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostPurseViewModel LostPurseViewModel { get; set; }

    }
}
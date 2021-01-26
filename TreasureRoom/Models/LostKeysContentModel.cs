using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostKeysContentModel : ContentModel
    {
        public LostKeysContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostKeysViewModel LostKeysViewModel { get; set; }

    }
}
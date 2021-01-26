using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostElectronicContentModel : ContentModel
    {
        public LostElectronicContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostElectronicViewModel LostElectronicViewModel { get; set; }

    }
}
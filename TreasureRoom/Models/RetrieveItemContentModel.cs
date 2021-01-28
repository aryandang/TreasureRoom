using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class RetrieveItemContentModel : ContentModel
    {
        public RetrieveItemContentModel(IPublishedContent content) : base(content)
        {

        }

        public RetrieveViewModel RetrieveViewModel { get; set; }
    }
}
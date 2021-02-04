using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class DeleteItemContentModel : ContentModel
    {
        public DeleteItemContentModel(IPublishedContent content) : base(content)
        {

        }

        public DeleteItemViewModel DeleteItemViewModel { get; set; }

    }
}
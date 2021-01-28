using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class EditOrDeleteItemContentModel : ContentModel
    {
        public EditOrDeleteItemContentModel(IPublishedContent content) : base(content)
        {

        }

        public EditOrDeleteItemViewModel EditOrDeleteItemViewModel { get; set; }

    }
}
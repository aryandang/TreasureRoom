using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class EditOrDeletePostContentModel : ContentModel
    {
        public EditOrDeletePostContentModel(IPublishedContent content) : base(content)
        {

        }

        public EditOrDeletePostViewModel EditOrDeletePostViewModel { get; set; }

    }
}
using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class PostContentModel : ContentModel
    {
        public PostContentModel(IPublishedContent content) : base(content)
        {

        }

        public PostViewModel PostViewModel { get; set; }

    }
}
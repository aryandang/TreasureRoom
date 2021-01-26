using TreasureRoom.Models.ViewModel;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace TreasureRoom.Models
{
    public class LostWalletContentModel : ContentModel
    {
        public LostWalletContentModel(IPublishedContent content) : base(content)
        {

        }

        public LostWalletViewModel LostWalletViewModel { get; set; }

    }
}
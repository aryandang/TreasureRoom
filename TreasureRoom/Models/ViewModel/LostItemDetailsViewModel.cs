using System.Collections.Generic;

namespace TreasureRoom.Models.ViewModel
{
    public class LostItemDetailsViewModel
    {
        public string ID { get; set; }
        public List<LostItemsViewModel> LostItemsData { get; set; }
    }
}
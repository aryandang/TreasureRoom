using System;

namespace TreasureRoom.Models.ViewModel
{
    public class LostItemsViewModel
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Postcode { get; set; }
        public string ItemType { get; set; }
        public string Image { get; set; }

        public DateTime? DatePosted { get; set; }
    }
}
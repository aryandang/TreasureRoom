using System;
using System.Web;

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
        public string Question1 { get; set; }
        public string Answer1 { get; set; }
        public string Question2 { get; set; }
        public string Answer2 { get; set; }
        public string Question3 { get; set; }
        public string Answer3 { get; set; }
    }
}
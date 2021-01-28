using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class LostItemDetailsViewModel
    {
        public string ID { get; set; }
        public List<LostItemsViewModel> LostItemsData { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class LostItemsViewModel
    {
        public string Description { get; set; }
        public string Postcode { get; set; }
        public string ItemType { get; set; }
        public string Image { get; set; }

        public DateTime DatePosted { get; set; }
    }
}
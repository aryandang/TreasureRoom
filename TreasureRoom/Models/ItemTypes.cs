using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TreasureRoom.Models;

namespace TreasureRoom.Models
{
    public class ItemTypes
    {
        public int ItemTypeID { get; set; }
        public string ItemType { get; set; }

        public List<ItemTypes> ItemTypesCollection { get; set; }
    }
}
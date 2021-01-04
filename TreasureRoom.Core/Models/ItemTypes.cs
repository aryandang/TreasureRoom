﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TreasureRoom.Models;

namespace TreasureRoom.Models
{
    public class ItemTypes
    {
        public IEnumerable<Get_ItemTypes_Result> GetItemTypes { get; set; }



        public int ItemTypeID { get; set; }
        public string ItemType { get; set; }

        //[NotMapped]
        //public List<ItemTypes> ItemTypesCollection { get; set; }
    }
}
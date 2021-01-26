﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class PostViewModel
    {

        [Required(ErrorMessage = "Must select the item type*")]
        [Display(Name = "Item Type")]
        public string ItemType { get; set; }
        public List<ItemTypesViewModel> ItemTypesData { get; set; }

    }
}
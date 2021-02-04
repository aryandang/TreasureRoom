using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class EditOrDeletePostViewModel
    {

        [Display(Name = "Key:")]
        [Required(ErrorMessage = "Must enter a key*")]
        public string EditID { get; set; }


        public List<LostItemsViewModel> LostItemsData { get; set; }
    }
}
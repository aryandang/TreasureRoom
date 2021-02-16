using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreasureRoom.Models.ViewModel
{
    public class DeleteItemViewModel
    {
        public List<LostItemsViewModel> LostItemsData { get; set; }


        [Display(Name = "Key:")]
        [Required(ErrorMessage = "Must enter a valid key")]
        public string EditID { get; set; }
    }
}
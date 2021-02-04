using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreasureRoom.Models.ViewModel
{
    public class HomeViewModel
    {
        [Display(Name = "Keyword")]
        [Required(ErrorMessage = "Must enter a keyword*")]
        public string Keyword { get; set; }

        [Display(Name = "Postcode")]
        [Required(ErrorMessage = "Must enter the postcode*")]
        public string Postcode { get; set; }

        [Display(Name = "Item Type")]
        [Required(ErrorMessage = "Must select the item type*")]
        public string ItemType { get; set; }
        public List<ItemTypesViewModel> ItemTypesData { get; set; }
    }
}
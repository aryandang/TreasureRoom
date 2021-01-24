using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class PostViewModel
    {

        public string ID { get; set; }

        [Required(ErrorMessage = "Must enter the lost item title")]
        [StringLength(20)]
        public string Title { get; set; }


        [Required(ErrorMessage = "Must enter a description")]
        [StringLength(55)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Must select the item type*")]
        public string ItemType { get; set; }
        public List<ItemTypesViewModel> ItemTypesData { get; set; }


        [Display(Name = "Item Type")]
        [Required(ErrorMessage = "Must enter a valid postcode")]
        [StringLength(10)]
        public string Postcode { get; set; }


        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }

        public DateTime DatePosted { get; set; }


        [Required(ErrorMessage = "Must select a title")]
        public string UserTitle { get; set; }
        public List<TitlesViewModel> TitlesData { get; set; }

        [Required(ErrorMessage = "Must enter your full name")]
        [StringLength(50)]
        public string FullName { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Must enter a valid email address")]
        [StringLength(100)]
        public string EmailAddress { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class PostViewModel
    {

        public string ID { get; set; }

        [Required(ErrorMessage = "Must enter the lost item title*")]
        [StringLength(20)]
        [Display(Name = "Post Title")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Must enter a description*")]
        [StringLength(55)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Must select the item type*")]
        [Display(Name = "Item Type")]
        public string ItemType { get; set; }
        public List<ItemTypesViewModel> ItemTypesData { get; set; }


        [Display(Name = "Postcode where lost item was found:")]
        [Required(ErrorMessage = "Must enter a valid postcode*")]
        [StringLength(10)]
        public string Postcode { get; set; }


        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Must select an image*")]
        public HttpPostedFileBase ImageFile { get; set; }


        [Display(Name = "Date when the lost item was found:")]
        [Required(ErrorMessage = "Must enter a date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatePosted { get; set; }


        [Required(ErrorMessage = "Must select a title*")]
        [Display(Name = "Title")]
        public string UserTitle { get; set; }
        public List<TitlesViewModel> TitlesData { get; set; }


        [Required(ErrorMessage = "Must enter your full name*")]
        [StringLength(50)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Must enter a valid email address*")]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
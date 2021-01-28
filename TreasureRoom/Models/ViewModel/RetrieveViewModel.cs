using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class RetrieveViewModel
    {
        public string ID { get; set; }
        public List<LostItemsViewModel> LostItemsData { get; set; }


        [Display(Name = "Answer 1")]
        [Required(ErrorMessage = "Must answer the question")]
        public string Answer1Input { get; set; }


        [Display(Name = "Answer 2")]
        [Required(ErrorMessage = "Must answer the question")]
        public string Answer2Input { get; set; }


        [Display(Name = "Answer 3")]
        public string Answer3Input { get; set; }


        [Required(ErrorMessage = "Must enter your full name*")]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Must enter a valid email address*")]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }



        [Phone]
        [Required(ErrorMessage = "Must enter a valid phone number")]
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
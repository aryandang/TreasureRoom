using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class RetrieveViewModel
    {
        public string ID { get; set; }
        public List<LostItemsViewModel> LostItemsData { get; set; }


        [Display(Name = "Answer 1")]
        [Required(ErrorMessage = "Must answer the question*")]
        [StringLength(100)]
        public string Answer1Input { get; set; }


        [Display(Name = "Answer 2")]
        [Required(ErrorMessage = "Must answer the question*")]
        [StringLength(100)]
        public string Answer2Input { get; set; }


        [Display(Name = "Answer 3")]
        [StringLength(100)]
        [Required(ErrorMessage = "Must answer the question*")]
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


        [Display(Name = "My age is above 18 and all data I have filled is honestly filled.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Only 18 above and honest data is permitted.*")]
        public bool Age18AboveAndHonesty { get; set; }


        [Display(Name = "I consent to usage of my personal data by Treasure Room.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must consent that your personal data will be used by Treasure Room*")]
        public bool ConsentToData { get; set; }
    }
}
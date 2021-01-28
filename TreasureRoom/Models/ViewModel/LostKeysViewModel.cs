using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TreasureRoom.Models.ViewModel
{
    public class LostKeysViewModel
    {

        public string ID { get; set; }

        public string EditID { get; set; }

        [Required(ErrorMessage = "Must enter the lost item title*")]
        [StringLength(20)]
        [Display(Name = "Post Title")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Must enter a description*")]
        [StringLength(55)]
        public string Description { get; set; }


        [Display(Name = "Item Type")]
        public string ItemType { get; set; }


        [Display(Name = "Postcode where lost item was found:")]
        [Required(ErrorMessage = "Must enter a valid postcode*")]
        [StringLength(10)]
        public string Postcode { get; set; }


        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Must select an image*")]
        public HttpPostedFileBase ImageFile { get; set; }


        [Display(Name = "Date when the lost item was found:")]
        [Required(ErrorMessage = "Must enter a date*")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatePosted { get; set; }


        [Display(Name = "Question 1")]
        [Required(ErrorMessage = "Must select one question*")]
        public string Question1 { get; set; }
        public List<QuestionsKeysViewModel> Question1Data { get; set; }


        [Display(Name = "Answer 1")]
        [Required(ErrorMessage = "Must answer the question")]
        public string Answer1 { get; set; }


        [Display(Name = "Question 2")]
        [Required(ErrorMessage = "Must select one question*")]
        public string Question2 { get; set; }
        public List<QuestionsKeysViewModel> Question2Data { get; set; }


        [Display(Name = "Answer 2")]
        [Required(ErrorMessage = "Must answer the question")]
        public string Answer2 { get; set; }


        [Display(Name = "Question 3")]
        public string Question3 { get; set; }
        public List<QuestionsKeysViewModel> Question3Data { get; set; }



        [Display(Name = "Answer 3")]
        public string Answer3 { get; set; }


        [Required(ErrorMessage = "Must select a title*")]
        [Display(Name = "Title")]
        public string UserTitle { get; set; }
        public List<TitlesViewModel> TitlesData { get; set; }


        [Required(ErrorMessage = "Must enter your full name*")]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Must enter a valid email address*")]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
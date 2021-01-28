﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using MailChimp.Net.Models;

namespace TreasureRoom.Models.ViewModel
{
    public class LostItemsViewModel
    {
        public string ID { get; set; }

        public string EditID { get; set; }

        [Display(Name = "Title of the lost item:")]
        public string Title { get; set; }


        [Display(Name = "Description of the lost item:")]
        public string Description { get; set; }


        [Display(Name = "Postcode where the lost item was found:")]
        public string Postcode { get; set; }


        [Display(Name = "Item Type:")]
        public string ItemType { get; set; }


        [Display(Name = "Image:")]
        public string ImagePath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }


        [Display(Name = "Date when the lost item was found:")]
        [Required(ErrorMessage = "Must enter a date*")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatePosted { get; set; }


        [Display(Name = "Question 1:")]
        public string Question1 { get; set; }


        public string Answer1 { get; set; }


        [Display(Name = "Question 2:")]
        public string Question2 { get; set; }


        public string Answer2 { get; set; }


        [Display(Name = "Question 3:")]
        public string Question3 { get; set; }


        public string Answer3 { get; set; }

        [Display(Name = "Title")]
        public string UserTitle { get; set; }


        [Display(Name = "Full Name:")]
        public string FullName { get; set; }


        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }

    }
}
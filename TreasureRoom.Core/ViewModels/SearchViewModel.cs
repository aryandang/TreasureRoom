using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace TreasureRoom.ViewModels
{
    public class SearchViewModel
    {

        //public SearchViewModel(IPublishedContent content, CultureInfo culture) : base(content, culture)
        //{
        //}

        [Required(ErrorMessage = "Please enter your name")]
        public string Keyword { get; set; }
          
        [Required]
        [MaxLength(9)]
        public string Postcode { get; set; }

        [Required]
        public string ItemType { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TreasureRoom.ViewModels
{
    public class EditProfileViewModel
    {
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public IEnumerable<SelectListItem> JobTitleOptions { get; set; }
    }
}
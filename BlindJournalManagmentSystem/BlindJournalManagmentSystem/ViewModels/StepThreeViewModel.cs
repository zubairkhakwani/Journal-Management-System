using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepThreeViewModel
    {

        public IEnumerable<SelectListItem> AllFields { get; set; }
        public IEnumerable<SelectListItem> AllSubjectCategories { get; set; }
        public string UseAsDummy { get; set; }

        [Required(ErrorMessage = "Please Select Atleast One Field As They Help Us Find The Most Suitable Editor To Review")]
        public IEnumerable<string> FieldsIds { get; set; }

        [Required(ErrorMessage = "Please Select Atleast One Subject Category")]
        public IEnumerable<string> SubjectCategoriesIds { get; set; }
    }
}
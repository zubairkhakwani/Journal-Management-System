using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepOneViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Type Is Required")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Title is missing")]
        [StringLength(50)]
        [MaxLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Abstract text is required")]
        [StringLength(300)]
        [MaxLength(300)]
        [Display(Name = "Abstract")]
        public string Abstract { get; set; }

        [Display(Name = "Open Access Agreement")]
        [RegularExpression("True", ErrorMessage = "OA Checkbox is a required field")]
        public bool OpenAccessAgreement { get; set; }

        [Display(Name = "Plagiarism Confirmation")]
        [RegularExpression("True", ErrorMessage = "Plagiarism Statement is a required field")]
        public bool PlagiarismConfirmation { get; set; }

        [Display(Name = "Duplicate Submission Confirmation")]
        [RegularExpression("True", ErrorMessage = "Duplicate Submission Checkbox is a required field")]
        public bool DuplicateSubmissionConfirmation { get; set; }

        public List<string> types { get; set; }
    }
}
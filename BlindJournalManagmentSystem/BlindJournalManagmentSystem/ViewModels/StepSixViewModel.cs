using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepSixViewModel
    {
        public string CoverLetter { get; set; }

        public string PreviouSubmittedArticleId { get; set; }
        [Required]
        public string PreviouslySubmittedRadioButton { get; set; }

        [Required]
        public string IsThereFundingToReportForThisSubmission { get; set; }

        [Required]
        public string DoesContainSupplementaryMaterial { get; set; }

        [Display(Name = "Confirm that the manuscript has been submitted solely to this journal and is not published, in press, or submitted elsewhere.")]
        [RegularExpression("True", ErrorMessage = "Confirm that the manuscript has been submitted solely to this journal and is not published, in press, or submitted elsewhere. is a required field")]
        public bool SubmittedSolelyToThisJournal { get; set; }

    }
}
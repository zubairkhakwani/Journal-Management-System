using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepFourViewModel
    {
        [Required]
        public List<string> AuthorsEmails { get; set; }

        public List<string> AuthorsInstitutions { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepFiveViewModel
    {
        public IEnumerable<string> OpposedAuthorsEmails { get; set; }

        public List<string> OpposedAuthorsInstitutions { get; set; }
    }
}
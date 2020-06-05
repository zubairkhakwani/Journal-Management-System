using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace BlindJournalManagmentSystem.ViewModels
{
    public class StepTwoViewModel
    {
        [Required(ErrorMessage = "Atleast One File Is Required")]
        public List<IFormFile> Files { get; set; }

        [Required]
        public IEnumerable<string> Designation { get; set; }
    }
}
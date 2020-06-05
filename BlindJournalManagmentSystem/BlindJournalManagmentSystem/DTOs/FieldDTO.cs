using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.DTOs;

namespace BlindJournalManagmentSystem.DTOs
{
    public class FieldDTO
    {
        [Required(ErrorMessage = "Name of the field is required")]
        [Display(Name = "Name")]
        [StringLength(100)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
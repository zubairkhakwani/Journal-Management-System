using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    public class Field
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name of the field is required")]
        [Display(Name =  "Name")]
        [StringLength(100)]
        [MaxLength(100)]
        public string Name { get; set; }

        //Navigation Property

        // Many to many between user and fields
        public ICollection<UserFields> userFields { get; set; }

        //Many To Many Between Article And Field
        public ICollection<ReviewerFields> reviewerFields { get; set; }

    }
}
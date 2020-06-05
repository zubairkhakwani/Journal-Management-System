using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prefix Required!")]
        [StringLength(100)]
        [Display(Name = "Prefix *")]
        public string Prefix { get; set; }

        [Required(ErrorMessage = "First Name Required!")]
        [StringLength(20)]
        [Display(Name = "First Name *")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required!")]
        [StringLength(20)]
        [Display(Name = "Last Name *")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Degree Required!")]
        [StringLength(50)]
        [Display(Name = "Degree Name *")]
        public string Degree { get; set; }

        [Required(ErrorMessage = "Department Required!")]
        [StringLength(50)]
        [Display(Name = "Department Name *")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Select atleast one Field")]
        [Display(Name = "Field of interest")]
        [ForeignKey("Fields")]
        public ICollection<int> FieldsIds { get; set; }

        // useful when data comming from database
        public ICollection<FieldDTO> Fields { get; set; }
        
        [Required(ErrorMessage = "Select an institute")]
        [Display(Name = "Institution")]
        [ForeignKey("Institution")]
        public int InstitutionId { get; set; }

        public InstitutionDTO Institution { get; set; }

    }
}
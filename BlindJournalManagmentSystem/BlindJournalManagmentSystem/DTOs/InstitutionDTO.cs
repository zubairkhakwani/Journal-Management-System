using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.DTOs;

namespace BlindJournalManagmentSystem.DTOs
{
    public class InstitutionDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Of Institution Required!")]
        [StringLength(100)]
        [Display(Name = "Name *")]
        public string Name { get; set; }

        [Required]
        [ForeignKey("address")]
        public int AddressId { get; set; }

        public AddressDTO address { get; set; }
    }
}
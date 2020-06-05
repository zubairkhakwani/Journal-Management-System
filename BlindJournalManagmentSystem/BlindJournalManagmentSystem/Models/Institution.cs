using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    public class Institution
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Of Institution Required!")]
        [StringLength(100)]
        [MaxLength(100)]
        [Display(Name = "Name *")]
        public string Name { get; set; }

        [ForeignKey("address")]
        [Required]
        public int AddressId { get; set; }

        [Required]
        public Address address { get; set; }

        // Navigation Property
        public ICollection<ApplicationUser> applicationUsers { get; set; }
    }
}
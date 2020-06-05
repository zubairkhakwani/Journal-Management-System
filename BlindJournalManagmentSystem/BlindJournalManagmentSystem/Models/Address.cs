using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlindJournalManagmentSystem.Models
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Country Required!")]
        [StringLength(56)]
        [MaxLength(56)]
        [Display(Name = "Country *")]
        public string Country { get; set; }

        [Required(ErrorMessage = "State Required!")]
        [StringLength(56)]
        [MaxLength(56)]
        [Display(Name = "State *")]
        public string State { get; set; }

        [Required(ErrorMessage = "City Required!")]
        [StringLength(50)]
        [MaxLength(50)]
        [Display(Name = "City *")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal Required!")]
        [StringLength(16)]
        [MaxLength(16)]
        [Display(Name = "Postal Code *")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Address Required!")]
        [StringLength(100)]
        [MaxLength(100)]
        [Display(Name = "Address *")]
        public string FullAddress { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required!")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        
    }
}
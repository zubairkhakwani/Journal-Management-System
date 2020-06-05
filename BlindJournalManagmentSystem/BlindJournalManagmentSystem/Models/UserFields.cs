using BlindJournalManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    public class UserFields
    {
        public int Id { get; set; }

        [ForeignKey("Fields")]
        public int FieldId { get; set; }
        [Required]
        public Field Fields { get; set; }

        [ForeignKey("Users")]
        public String UserId { get; set; }

        public ApplicationUser Users { get; set; }
    }
}

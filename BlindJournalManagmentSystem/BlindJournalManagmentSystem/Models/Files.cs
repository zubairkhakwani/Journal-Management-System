using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    [Table("Files")]
    public class Files
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [MaxLength(150)]
        [Display(Name ="Select File")]
        public string File { get; set; }

        [Required]
        [StringLength(150)]
        [MaxLength(150)]
        [Display(Name = "File Designation")]
        public string Designation { get; set; }

        [ForeignKey("Article")]
        [Required]
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlindJournalManagmentSystem.Models;

namespace BlindJournalManagmentSystem.Models
{
    public class SubjectCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation Property
        // Many to many between article and subject category 
        public ICollection<ArticleSubjectCategories> articleSubjectCategories { get; set; }
    }
}
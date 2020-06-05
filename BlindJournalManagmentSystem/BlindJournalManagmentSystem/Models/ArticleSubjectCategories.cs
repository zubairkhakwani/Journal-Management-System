using BlindJournalManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlindJournalManagmentSystem.Models
{
    // Many To Many Table
    public class ArticleSubjectCategories
    {
        public int Id { get; set; }

        [Required]
        public SubjectCategory SubjectCategory { get; set; }
        [ForeignKey("SubjectCategories")]
        public int SubjectCategoryId { get; set; }

        public Article Article { get; set; }
        [ForeignKey("Articles")]
        public int ArticleId { get; set; }
    }
}
